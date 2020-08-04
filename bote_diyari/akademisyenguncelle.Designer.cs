namespace bote_diyari
{
    partial class akademisyenguncelle
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
            this.btara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btgeri = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unvan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbuni = new System.Windows.Forms.ComboBox();
            this.btguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btara
            // 
            this.btara.Location = new System.Drawing.Point(282, 36);
            this.btara.Name = "btara";
            this.btara.Size = new System.Drawing.Size(75, 23);
            this.btara.TabIndex = 15;
            this.btara.Text = "Ara";
            this.btara.UseVisualStyleBackColor = true;
            this.btara.Click += new System.EventHandler(this.btara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Akademisyen Ara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // btgeri
            // 
            this.btgeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btgeri.Location = new System.Drawing.Point(18, 277);
            this.btgeri.Name = "btgeri";
            this.btgeri.Size = new System.Drawing.Size(56, 27);
            this.btgeri.TabIndex = 17;
            this.btgeri.Text = "Geri";
            this.btgeri.UseVisualStyleBackColor = true;
            this.btgeri.Click += new System.EventHandler(this.btgeri_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.unvan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbuni);
            this.groupBox1.Location = new System.Drawing.Point(430, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 301);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Başlama Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "E mail Adresi";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(87, 144);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(162, 20);
            this.mail.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unvan
            // 
            this.unvan.Location = new System.Drawing.Point(87, 76);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(73, 20);
            this.unvan.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Adı Soyadı";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(87, 47);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(162, 20);
            this.ad.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(70, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Akademisyen Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ünvan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Üniversitesi";
            // 
            // cbuni
            // 
            this.cbuni.FormattingEnabled = true;
            this.cbuni.Location = new System.Drawing.Point(87, 108);
            this.cbuni.Name = "cbuni";
            this.cbuni.Size = new System.Drawing.Size(162, 21);
            this.cbuni.TabIndex = 33;
            // 
            // btguncelle
            // 
            this.btguncelle.BackColor = System.Drawing.Color.Transparent;
            this.btguncelle.Enabled = false;
            this.btguncelle.Image = global::bote_diyari.Properties.Resources.update;
            this.btguncelle.Location = new System.Drawing.Point(341, 247);
            this.btguncelle.Name = "btguncelle";
            this.btguncelle.Size = new System.Drawing.Size(56, 57);
            this.btguncelle.TabIndex = 18;
            this.btguncelle.UseVisualStyleBackColor = false;
            this.btguncelle.Click += new System.EventHandler(this.btguncelle_Click);
            // 
            // akademisyenguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(414, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btguncelle);
            this.Controls.Add(this.btgeri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "akademisyenguncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "akademisyenguncelle";
            this.Load += new System.EventHandler(this.akademisyenguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btguncelle;
        private System.Windows.Forms.Button btgeri;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox unvan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbuni;
    }
}