namespace bote_diyari
{
    partial class geri
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
            this.btders = new System.Windows.Forms.Button();
            this.btakad = new System.Windows.Forms.Button();
            this.btuniler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btders
            // 
            this.btders.Location = new System.Drawing.Point(88, 237);
            this.btders.Name = "btders";
            this.btders.Size = new System.Drawing.Size(120, 33);
            this.btders.TabIndex = 7;
            this.btders.Text = "Dersler";
            this.btders.UseVisualStyleBackColor = true;
            this.btders.Click += new System.EventHandler(this.btders_Click);
            // 
            // btakad
            // 
            this.btakad.Location = new System.Drawing.Point(88, 195);
            this.btakad.Name = "btakad";
            this.btakad.Size = new System.Drawing.Size(120, 36);
            this.btakad.TabIndex = 5;
            this.btakad.Text = "Akademisyenler";
            this.btakad.UseVisualStyleBackColor = true;
            this.btakad.Click += new System.EventHandler(this.btakad_Click);
            // 
            // btuniler
            // 
            this.btuniler.Location = new System.Drawing.Point(88, 154);
            this.btuniler.Name = "btuniler";
            this.btuniler.Size = new System.Drawing.Size(120, 35);
            this.btuniler.TabIndex = 4;
            this.btuniler.Text = "Üniversiteler";
            this.btuniler.UseVisualStyleBackColor = true;
            this.btuniler.Click += new System.EventHandler(this.btuniler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.Image = global::bote_diyari.Properties.Resources.bötediyarilogo4;
            this.logo.Location = new System.Drawing.Point(59, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(183, 136);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // geri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(302, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btders);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btakad);
            this.Controls.Add(this.btuniler);
            this.Name = "geri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btders;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btakad;
        private System.Windows.Forms.Button btuniler;
        private System.Windows.Forms.Button button1;
    }
}