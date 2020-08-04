using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bote_diyari
{
    public partial class akademisyenekle : Form
    {
        public akademisyenekle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        private void btgeri_Click(object sender, EventArgs e)
        {
            adminanasayfa admin = new adminanasayfa();
            admin.Show();
            this.Close();
        }

        private void akademisyenekle_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dateTimePicker1.Text = DateTime.Now.ToString();
            akadi.Text = "";
            unvan.Text = "";
            mail.Text="";
            string kod = "select * from universite";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod,con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            cbuni.DataSource = dt;
            cbuni.ValueMember = "unino";
            cbuni.DisplayMember = "uniadi";
            con.Close();


        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string adi=akadi.Text;
            string unvani = unvan.Text;
            string maili = mail.Text;
            int uni = Convert.ToInt32(cbuni.SelectedValue);
          

            if (adi == "" || unvani == "" || maili == "") MessageBox.Show("Lütfen Gerekli  Alanları Doldurunuz..");
            else 
            {
                string eklemekodu = "INSERT INTO akademisyen (adsoyad,unvan,unino,mail,bastarih) VALUES ('" + adi + "','" + unvani + "','" + uni + "','" + maili + "','"+dateTimePicker1.Value.ToShortDateString()+"')";

                OleDbCommand calistir = new OleDbCommand(eklemekodu, con);
                con.Open();
                calistir.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarıyla Eklendi");
                akademisyenekle_Load(sender, e);
            }
        }

        private void sıfırla_Click(object sender, EventArgs e)
        {
            akademisyenekle_Load(sender, e);
        }


    }
}
