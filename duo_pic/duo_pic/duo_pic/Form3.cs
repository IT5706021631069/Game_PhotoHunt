using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace duo_pic
{
    public partial class Form3 : Form
    {
        string[] hiscore = new string[10];
        string q;
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader dr;
        int score=0,num=0;
        public Form3()
        {

            InitializeComponent();
            
           
            if (!Form2.toform3.Equals(""))
            {
                score = int.Parse(Form2.toform3);
                if (score == 100)
                {
                    pictureBox1.Image = Properties.Resources.win_txt_01;
                    this.BackgroundImage = Properties.Resources.win_bg_01;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.over;
                    this.BackgroundImage = Properties.Resources.over_bg_01;
                }
            }else
                this.BackgroundImage = Properties.Resources.win_bg_01;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            String str_connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ";
            str_connectionstring += Application.StartupPath + @"\Database.mdb";
            con.ConnectionString = str_connectionstring;
            cmd.Connection = con;
            loaddata();
            usr();
        }
        private void loaddata()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            try
            {
                string q = "select name_usr,score from hiscore";
                cmd.CommandText = q;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {       
                        listBox1.Items.Add(dr[0].ToString());
                        listBox2.Items.Add(dr[1].ToString());
                    }
                    
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void usr()
        {
            listBox2.Items.CopyTo(hiscore,0);
            
            if (score > int.Parse(hiscore[9]))
            {
                for (int i = 9; i >= 0; i--)
                {
                    if (int.Parse(hiscore[i]) < score || int.Parse(hiscore[i])==score)
                    {
                        num = i+1;
                        input_name.Visible = true;
                        label3.Visible = true;
                        number_user.Text = num.ToString();
                    }
                }
            }
                      
        }
        private void dosomething(string q)
        {
            try
            {
                con.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                con.Close();
                loaddata();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q = "update hiscore set name_usr='" + input_name.Text.ToString() + "',score='" + score.ToString() + "' where id=" + num.ToString();
            dosomething(q);
    
        }
        private void backmenu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();  
        }
    }
}
