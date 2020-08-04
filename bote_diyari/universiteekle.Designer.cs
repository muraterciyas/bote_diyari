namespace bote_diyari
{
    partial class universiteekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.uniadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kurulustarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbote = new System.Windows.Forms.CheckBox();
            this.cbyuksek = new System.Windows.Forms.CheckBox();
            this.tabanpuan = new System.Windows.Forms.TextBox();
            this.tavanpuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sıfırla = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.btgeriuni = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.kontenjan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üniversite Adı";
            // 
            // uniadi
            // 
            this.uniadi.Location = new System.Drawing.Point(141, 61);
            this.uniadi.Name = "uniadi";
            this.uniadi.Size = new System.Drawing.Size(147, 20);
            this.uniadi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kuruluş Tarihi";
            // 
            // kurulustarih
            // 
            this.kurulustarih.Location = new System.Drawing.Point(141, 90);
            this.kurulustarih.Name = "kurulustarih";
            this.kurulustarih.Size = new System.Drawing.Size(60, 20);
            this.kurulustarih.TabIndex = 7;
            this.kurulustarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kurulustarih_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(YYYY)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bulunduğu İl";
            // 
            // cbil
            // 
            this.cbil.FormattingEnabled = true;
            this.cbil.Location = new System.Drawing.Point(141, 124);
            this.cbil.Name = "cbil";
            this.cbil.Size = new System.Drawing.Size(121, 21);
            this.cbil.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tavan Puan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yüksek Lisans";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Böte Durumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Taban Puan";
            // 
            // cbbote
            // 
            this.cbbote.AutoSize = true;
            this.cbbote.Location = new System.Drawing.Point(141, 153);
            this.cbbote.Name = "cbbote";
            this.cbbote.Size = new System.Drawing.Size(62, 17);
            this.cbbote.TabIndex = 15;
            this.cbbote.Text = "Mevcut";
            this.cbbote.UseVisualStyleBackColor = true;
            this.cbbote.Click += new System.EventHandler(this.cbbote_Click);
            // 
            // cbyuksek
            // 
            this.cbyuksek.AutoSize = true;
            this.cbyuksek.Location = new System.Drawing.Point(141, 182);
            this.cbyuksek.Name = "cbyuksek";
            this.cbyuksek.Size = new System.Drawing.Size(62, 17);
            this.cbyuksek.TabIndex = 17;
            this.cbyuksek.Text = "Mevcut";
            this.cbyuksek.UseVisualStyleBackColor = true;
            // 
            // tabanpuan
            // 
            this.tabanpuan.Location = new System.Drawing.Point(141, 235);
            this.tabanpuan.Name = "tabanpuan";
            this.tabanpuan.Size = new System.Drawing.Size(60, 20);
            this.tabanpuan.TabIndex = 18;
            this.tabanpuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabanpuan_KeyPress);
            // 
            // tavanpuan
            // 
            this.tavanpuan.Location = new System.Drawing.Point(141, 267);
            this.tavanpuan.Name = "tavanpuan";
            this.tavanpuan.Size = new System.Drawing.Size(60, 20);
            this.tavanpuan.TabIndex = 19;
            this.tavanpuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tavanpuan_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "(0-500 arası)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "(0-500 arası)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(104, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Üniversite Ekleme";
            // 
            // sıfırla
            // 
            this.sıfırla.Image = global::bote_diyari.Properties.Resources.cop;
            this.sıfırla.Location = new System.Drawing.Point(112, 300);
            this.sıfırla.Name = "sıfırla";
            this.sıfırla.Size = new System.Drawing.Size(66, 57);
            this.sıfırla.TabIndex = 23;
            this.sıfırla.UseVisualStyleBackColor = true;
            this.sıfırla.Click += new System.EventHandler(this.sıfırla_Click);
            // 
            // ekle
            // 
            this.ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekle.Image = global::bote_diyari.Properties.Resources.asdadd;
            this.ekle.Location = new System.Drawing.Point(184, 300);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(59, 57);
            this.ekle.TabIndex = 24;
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // btgeriuni
            // 
            this.btgeriuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btgeriuni.Location = new System.Drawing.Point(12, 341);
            this.btgeriuni.Name = "btgeriuni";
            this.btgeriuni.Size = new System.Drawing.Size(66, 33);
            this.btgeriuni.TabIndex = 3;
            this.btgeriuni.Text = "Geri";
            this.btgeriuni.UseVisualStyleBackColor = true;
            this.btgeriuni.Click += new System.EventHandler(this.btgeriuni_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Kontenjan";
            // 
            // kontenjan
            // 
            this.kontenjan.Location = new System.Drawing.Point(141, 209);
            this.kontenjan.Name = "kontenjan";
            this.kontenjan.Size = new System.Drawing.Size(38, 20);
            this.kontenjan.TabIndex = 26;
            this.kontenjan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kontenjan_KeyPress);
            // 
            // universiteekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(340, 386);
            this.Controls.Add(this.kontenjan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.sıfırla);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tavanpuan);
            this.Controls.Add(this.tabanpuan);
            this.Controls.Add(this.cbyuksek);
            this.Controls.Add(this.cbbote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kurulustarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uniadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btgeriuni);
            this.Name = "universiteekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "universiteekle";
            this.Load += new System.EventHandler(this.universiteekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btgeriuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uniadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kurulustarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbbote;
        private System.Windows.Forms.CheckBox cbyuksek;
        private System.Windows.Forms.TextBox tabanpuan;
        private System.Windows.Forms.TextBox tavanpuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button sıfırla;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox kontenjan;
    }
}