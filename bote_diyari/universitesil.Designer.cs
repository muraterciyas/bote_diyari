namespace bote_diyari
{
    partial class universitesil
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btgeriuni
            // 
            this.btgeriuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btgeriuni.Location = new System.Drawing.Point(11, 275);
            this.btgeriuni.Name = "btgeriuni";
            this.btgeriuni.Size = new System.Drawing.Size(74, 29);
            this.btgeriuni.TabIndex = 4;
            this.btgeriuni.Text = "Geri";
            this.btgeriuni.UseVisualStyleBackColor = true;
            this.btgeriuni.Click += new System.EventHandler(this.btgeriuni_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Üniversite Ara";
            // 
            // btara
            // 
            this.btara.Location = new System.Drawing.Point(301, 41);
            this.btara.Name = "btara";
            this.btara.Size = new System.Drawing.Size(75, 23);
            this.btara.TabIndex = 7;
            this.btara.Text = "Ara";
            this.btara.UseVisualStyleBackColor = true;
            this.btara.Click += new System.EventHandler(this.btara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btsil
            // 
            this.btsil.Enabled = false;
            this.btsil.Image = global::bote_diyari.Properties.Resources.cop;
            this.btsil.Location = new System.Drawing.Point(329, 239);
            this.btsil.Name = "btsil";
            this.btsil.Size = new System.Drawing.Size(65, 65);
            this.btsil.TabIndex = 9;
            this.btsil.UseVisualStyleBackColor = true;
            this.btsil.Click += new System.EventHandler(this.btsil_Click);
            // 
            // universitesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(411, 314);
            this.Controls.Add(this.btsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btgeriuni);
            this.Name = "universitesil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "universitesil";
            this.Load += new System.EventHandler(this.universitesil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btgeriuni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btsil;
    }
}