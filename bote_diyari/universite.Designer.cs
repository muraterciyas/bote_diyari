namespace bote_diyari
{
    partial class universite
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
            this.btgeriuni = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbote = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtavan = new System.Windows.Forms.CheckBox();
            this.cbtaban = new System.Windows.Forms.CheckBox();
            this.cbyuksek = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btgeriuni
            // 
            this.btgeriuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btgeriuni.Location = new System.Drawing.Point(12, 265);
            this.btgeriuni.Name = "btgeriuni";
            this.btgeriuni.Size = new System.Drawing.Size(74, 29);
            this.btgeriuni.TabIndex = 2;
            this.btgeriuni.Text = "Geri";
            this.btgeriuni.UseVisualStyleBackColor = true;
            this.btgeriuni.Click += new System.EventHandler(this.btgeriuni_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 186);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbbote
            // 
            this.cbbote.AutoSize = true;
            this.cbbote.Location = new System.Drawing.Point(12, 23);
            this.cbbote.Name = "cbbote";
            this.cbbote.Size = new System.Drawing.Size(167, 17);
            this.cbbote.TabIndex = 4;
            this.cbbote.Text = "Böte bölümü olan üniversiteler";
            this.cbbote.UseVisualStyleBackColor = true;
            this.cbbote.Click += new System.EventHandler(this.cbbote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Böte bölümü olmayan üniversitelerde yüksek lisans araması yapılamaz...";
            // 
            // cbtavan
            // 
            this.cbtavan.AutoSize = true;
            this.cbtavan.Location = new System.Drawing.Point(459, 23);
            this.cbtavan.Name = "cbtavan";
            this.cbtavan.Size = new System.Drawing.Size(128, 17);
            this.cbtavan.TabIndex = 12;
            this.cbtavan.Text = "Tavan Puan Sıralama";
            this.cbtavan.UseVisualStyleBackColor = true;
            this.cbtavan.Click += new System.EventHandler(this.cbtavan_Click);
            // 
            // cbtaban
            // 
            this.cbtaban.AutoSize = true;
            this.cbtaban.Location = new System.Drawing.Point(325, 23);
            this.cbtaban.Name = "cbtaban";
            this.cbtaban.Size = new System.Drawing.Size(128, 17);
            this.cbtaban.TabIndex = 11;
            this.cbtaban.Text = "Taban Puan Sıralama";
            this.cbtaban.UseVisualStyleBackColor = true;
            this.cbtaban.Click += new System.EventHandler(this.cbtaban_Click);
            // 
            // cbyuksek
            // 
            this.cbyuksek.AutoSize = true;
            this.cbyuksek.Location = new System.Drawing.Point(215, 23);
            this.cbyuksek.Name = "cbyuksek";
            this.cbyuksek.Size = new System.Drawing.Size(95, 17);
            this.cbyuksek.TabIndex = 9;
            this.cbyuksek.Text = "Yüksek Lisans";
            this.cbyuksek.UseVisualStyleBackColor = true;
            this.cbyuksek.Click += new System.EventHandler(this.cbyuksek_Click);
            // 
            // universite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(596, 306);
            this.Controls.Add(this.cbtavan);
            this.Controls.Add(this.cbtaban);
            this.Controls.Add(this.cbyuksek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbote);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btgeriuni);
            this.Name = "universite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "universite";
            this.Load += new System.EventHandler(this.universite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btgeriuni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbbote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbtavan;
        private System.Windows.Forms.CheckBox cbtaban;
        private System.Windows.Forms.CheckBox cbyuksek;

    }
}