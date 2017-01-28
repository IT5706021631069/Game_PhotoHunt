using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duo_pic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Form2 fgame = new Form2();
            fgame.Show();
            this.Hide();
        }

        private void btn_hiscore_Click(object sender, EventArgs e)
        {
            Form2 fplay = new Form2();
            Form3 fscore = new Form3();
            fscore.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
