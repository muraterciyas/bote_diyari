namespace bote_diyari
{
    partial class akademisyen
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
            this.btgeriak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btdersler = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btakademisyen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btgeriak
            // 
            this.btgeriak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btgeriak.Location = new System.Drawing.Point(12, 243);
            this.btgeriak.Name = "btgeriak";
            this.btgeriak.Size = new System.Drawing.Size(64, 30);
            this.btgeriak.TabIndex = 2;
            this.btgeriak.Text = "Geri";
            this.btgeriak.UseVisualStyleBackColor = true;
            this.btgeriak.Click += new System.EventHandler(this.btgeriak_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aranan Akademisyen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btdersler
            // 
            this.btdersler.Enabled = false;
            this.btdersler.Location = new System.Drawing.Point(313, 154);
            this.btdersler.Name = "btdersler";
            this.btdersler.Size = new System.Drawing.Size(75, 44);
            this.btdersler.TabIndex = 6;
            this.btdersler.Text = "Verdiği Dersleri Gör";
            this.btdersler.UseVisualStyleBackColor = true;
            this.btdersler.Click += new System.EventHandler(this.btdersler_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(403, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 134);
            this.listBox1.TabIndex = 9;
            // 
            // btakademisyen
            // 
            this.btakademisyen.Location = new System.Drawing.Point(306, 88);
            this.btakademisyen.Name = "btakademisyen";
            this.btakademisyen.Size = new System.Drawing.Size(91, 46);
            this.btakademisyen.TabIndex = 10;
            this.btakademisyen.Text = "Akademisyenleri Göster";
            this.btakademisyen.UseVisualStyleBackColor = true;
            this.btakademisyen.Click += new System.EventHandler(this.btakademisyen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ADI";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "UNİSİ";
            this.label5.Visible = false;
            // 
            // akademisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(606, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btakademisyen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btdersler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btgeriak);
            this.Name = "akademisyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "akademisyen";
            this.Load += new System.EventHandler(this.akademisyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btgeriak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btdersler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btakademisyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;

    }
}