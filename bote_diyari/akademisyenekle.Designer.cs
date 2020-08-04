namespace bote_diyari
{
    partial class akademisyenekle
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
            this.btgeri = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbuni = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unvan = new System.Windows.Forms.TextBox();
            this.akadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.sıfırla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btgeri
            // 
            this.btgeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btgeri.Location = new System.Drawing.Point(12, 320);
            this.btgeri.Name = "btgeri";
            this.btgeri.Size = new System.Drawing.Size(66, 29);
            this.btgeri.TabIndex = 4;
            this.btgeri.Text = "Geri";
            this.btgeri.UseVisualStyleBackColor = true;
            this.btgeri.Click += new System.EventHandler(this.btgeri_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(79, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Akademisyen Ekleme";
            // 
            // cbuni
            // 
            this.cbuni.FormattingEnabled = true;
            this.cbuni.Location = new System.Drawing.Point(140, 139);
            this.cbuni.Name = "cbuni";
            this.cbuni.Size = new System.Drawing.Size(147, 21);
            this.cbuni.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Üniversitesi";
            // 
            // unvan
            // 
            this.unvan.Location = new System.Drawing.Point(140, 108);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(85, 20);
            this.unvan.TabIndex = 26;
            // 
            // akadi
            // 
            this.akadi.Location = new System.Drawing.Point(140, 79);
            this.akadi.Name = "akadi";
            this.akadi.Size = new System.Drawing.Size(147, 20);
            this.akadi.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ünvan";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(140, 173);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(147, 20);
            this.mail.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "E-Mail";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Başlama Tarihi";
            // 
            // ekle
            // 
            this.ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekle.Image = global::bote_diyari.Properties.Resources.asdadd;
            this.ekle.Location = new System.Drawing.Point(159, 245);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(57, 51);
            this.ekle.TabIndex = 36;
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sıfırla
            // 
            this.sıfırla.Image = global::bote_diyari.Properties.Resources.cop;
            this.sıfırla.Location = new System.Drawing.Point(97, 245);
            this.sıfırla.Name = "sıfırla";
            this.sıfırla.Size = new System.Drawing.Size(56, 51);
            this.sıfırla.TabIndex = 35;
            this.sıfırla.UseVisualStyleBackColor = true;
            this.sıfırla.Click += new System.EventHandler(this.sıfırla_Click);
            // 
            // akademisyenekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.sıfırla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbuni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unvan);
            this.Controls.Add(this.akadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btgeri);
            this.Name = "akademisyenekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "akademisyenekle";
            this.Load += new System.EventHandler(this.akademisyenekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btgeri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbuni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unvan;
        private System.Windows.Forms.TextBox akadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sıfırla;
    }
}