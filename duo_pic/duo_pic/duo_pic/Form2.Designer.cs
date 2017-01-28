namespace duo_pic
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pro_time = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resume = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.la_score = new System.Windows.Forms.Label();
            this.timer_next = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_resume)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cir.png");
            // 
            // pro_time
            // 
            this.pro_time.Location = new System.Drawing.Point(101, 526);
            this.pro_time.Name = "pro_time";
            this.pro_time.Size = new System.Drawing.Size(693, 23);
            this.pro_time.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pro_time.TabIndex = 0;
            this.pro_time.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(36, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // btn_resume
            // 
            this.btn_resume.Image = global::duo_pic.Properties.Resources.resume_btn;
            this.btn_resume.Location = new System.Drawing.Point(800, 523);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(71, 26);
            this.btn_resume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_resume.TabIndex = 2;
            this.btn_resume.TabStop = false;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(431, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score :";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "p1.jpg");
            this.imageList2.Images.SetKeyName(1, "p2.jpg");
            this.imageList2.Images.SetKeyName(2, "p3.jpg");
            this.imageList2.Images.SetKeyName(3, "p4.jpg");
            // 
            // la_score
            // 
            this.la_score.AutoSize = true;
            this.la_score.BackColor = System.Drawing.Color.Transparent;
            this.la_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_score.Location = new System.Drawing.Point(418, 20);
            this.la_score.Name = "la_score";
            this.la_score.Size = new System.Drawing.Size(62, 42);
            this.la_score.TabIndex = 4;
            this.la_score.Text = "00";
            // 
            // timer_next
            // 
            this.timer_next.Interval = 80;
            this.timer_next.Tick += new System.EventHandler(this.timer_next_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::duo_pic.Properties.Resources.p1;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.la_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pro_time);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form2";
            this.Text = "Photo Hunter";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_resume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar pro_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_resume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label la_score;
        private System.Windows.Forms.Timer timer_next;
    }
}