namespace bote_diyari
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.gir = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // kadi
            // 
            resources.ApplyResources(this.kadi, "kadi");
            this.kadi.Name = "kadi";
            // 
            // parola
            // 
            resources.ApplyResources(this.parola, "parola");
            this.parola.Name = "parola";
            // 
            // gir
            // 
            resources.ApplyResources(this.gir, "gir");
            this.gir.Name = "gir";
            this.gir.UseVisualStyleBackColor = true;
            this.gir.Click += new System.EventHandler(this.gir_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.geri, "geri");
            this.geri.Name = "geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::bote_diyari.Properties.Resources.Untitled_19_256_kopya1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // giris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.geri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gir);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.kadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button gir;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}