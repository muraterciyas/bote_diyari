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
    public partial class verilendersduzenle : Form
    {
        public verilendersduzenle()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");


        private void btgeriak_Click(object sender, EventArgs e)
        {
            adminanasayfa admin = new adminanasayfa();
            admin.Show();
            this.Close();
        }

        private void verilendersduzenle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            string kod="SELECT * FROM universite  WHERE botedurumu=Yes ORDER BY uniadi" ;
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod,con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember="unino";
            comboBox1.DisplayMember = "uniadi";
            con.Close();

        }

        private void btliste_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            int secili = Convert.ToInt32(comboBox1.SelectedValue);

            string kod = "SELECT dersler.dersadi,akademisyen.adsoyad,verilenders.verders FROM dersler,akademisyen, verilenders WHERE dersler.dersid=verilenders.dersid AND  akademisyen.unino=verilenders.unino AND akademisyen.akno=verilenders.akno AND verilenders.unino="+secili+" ORDER BY dersler.dersadi;";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
       
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width != 680)
            {
                this.Width += 10;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Width != 420)
            {
                this.Width -= 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //seçili olanı güncelle
            timer1.Enabled = true;
            timer2.Enabled = false;
            button4.Enabled = true;
            button1.Enabled = false;
            string ders, akademisyen;
            ders = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            akademisyen = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            string kod = "Select * FROM dersler WHERE dersid NOT IN(SELECT dersid FROM verilenders WHERE unino=" + Convert.ToInt32(comboBox1.SelectedValue) + ") or dersadi='"+ders+"' ORDER BY dersadi ";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            cbders.DataSource = dt;
            cbders.ValueMember = "dersid";
            cbders.DisplayMember = "dersadi";
            con.Close();
            cbders.Text = ders;


            string kod2 = "SELECT * FROM akademisyen WHERE unino =" + Convert.ToInt32(comboBox1.SelectedValue) + "";
            OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            con.Open();
            cbakademisyen.DataSource = dt2;
            cbakademisyen.ValueMember = "akno";
            cbakademisyen.DisplayMember = "adsoyad";
            con.Close();
            cbakademisyen.Text = akademisyen;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            //yeni ders ataması yap eklemesi

            int ders = Convert.ToInt32(cbders.SelectedValue);
            int ak = Convert.ToInt32(cbakademisyen.SelectedValue);
            int uni = Convert.ToInt32(comboBox1.SelectedValue);
            string kod = "INSERT INTO verilenders (unino,dersid,akno) VALUES ('"+uni+"','"+ders+"','"+ak+"')";
            OleDbCommand com = new OleDbCommand(kod,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(comboBox1.Text+"'nde "+cbders.Text+" adlı ders "+cbakademisyen.Text+" tarafıdnan verilmeye başlanmıştır.");

            int secili = Convert.ToInt32(comboBox1.SelectedValue);

            string kod2 = "SELECT dersler.dersadi,akademisyen.adsoyad,verilenders.verders FROM dersler,akademisyen, verilenders WHERE dersler.dersid=verilenders.dersid AND  akademisyen.unino=verilenders.unino AND akademisyen.akno=verilenders.akno AND verilenders.unino=" + secili + " ORDER BY dersler.dersadi;";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod2, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //yeni ders ekleme listeleemesi comboboxlara
            timer1.Enabled = true;
            timer2.Enabled = false;
            button1.Enabled = true;
            button4.Enabled = false;
            string kod = "Select * FROM dersler WHERE dersid NOT IN(SELECT dersid FROM verilenders WHERE unino="+Convert.ToInt32(comboBox1.SelectedValue)+") ORDER BY dersadi";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            cbders.DataSource = dt;
            cbders.ValueMember = "dersid";
            cbders.DisplayMember = "dersadi";
            con.Close();


            string kod2 = "SELECT * FROM akademisyen WHERE unino =" + Convert.ToInt32(comboBox1.SelectedValue) + "";
            OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            con.Open();
            cbakademisyen.DataSource = dt2;
            cbakademisyen.ValueMember = "akno";
            cbakademisyen.DisplayMember = "adsoyad";
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;

            int birincil = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int uni = Convert.ToInt32(comboBox1.SelectedValue);
            int ak = Convert.ToInt32(cbakademisyen.SelectedValue);
            int ders = Convert.ToInt32(cbders.SelectedValue);

            string eskiders = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string aka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string kod="UPDATE verilenders SET akno='"+ak+"', dersid='"+ders+"' WHERE unino="+uni+" AND verders="+birincil+";";
            OleDbCommand com=new OleDbCommand(kod,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("'"+eskiders+"' '"+cbders.Text+"' olarak , '"+aka+"' ise '"+cbakademisyen.Text+"' olarak başarıyla Güncellendi");

            int secili = Convert.ToInt32(comboBox1.SelectedValue);
            string kod2 = "SELECT dersler.dersadi,akademisyen.adsoyad,verilenders.verders FROM dersler,akademisyen, verilenders WHERE dersler.dersid=verilenders.dersid AND  akademisyen.unino=verilenders.unino AND akademisyen.akno=verilenders.akno AND verilenders.unino=" + secili + " ORDER BY dersler.dersadi;";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod2, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
           
        }
    }
}
