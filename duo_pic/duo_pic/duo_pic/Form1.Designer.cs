namespace duo_pic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_hiscore = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.AllowDrop = true;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.ForeColor = System.Drawing.Color.Transparent;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.Location = new System.Drawing.Point(69, 416);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(210, 67);
            this.btn_start.TabIndex = 1;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_hiscore
            // 
            this.btn_hiscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hiscore.Image = global::duo_pic.Properties.Resources.score_btn;
            this.btn_hiscore.Location = new System.Drawing.Point(334, 416);
            this.btn_hiscore.Name = "btn_hiscore";
            this.btn_hiscore.Size = new System.Drawing.Size(269, 67);
            this.btn_hiscore.TabIndex = 2;
            this.btn_hiscore.UseVisualStyleBackColor = true;
            this.btn_hiscore.Click += new System.EventHandler(this.btn_hiscore_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::duo_pic.Properties.Resources.exit_btn;
            this.btn_exit.Location = new System.Drawing.Point(646, 416);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(182, 67);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::duo_pic.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_hiscore);
            this.Controls.Add(this.btn_start);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Photo Hunter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        internal System.Windows.Forms.Button btn_hiscore;
        private System.Windows.Forms.Button btn_exit;

    }
}

