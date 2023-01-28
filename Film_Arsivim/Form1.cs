using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;



namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser browser;


        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERHAN;Initial Catalog=Film_Arsivim;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblfilmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmAd.Text != "" && txtKategori.Text != "" && TxtFilmlinki.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tblfilmler (ad,kategori,link) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
                komut.Parameters.AddWithValue("@p2", txtKategori.Text);
                komut.Parameters.AddWithValue("@p3", TxtFilmlinki.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni film sisteme kaydedildi.", "Film Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filmler();
            }
            else
            {
                MessageBox.Show("Film ismi, kategorisi veya linki boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string link = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            chromiumWebBrowser1.LoadUrl(link);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblfilmler set durum='true' where Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            filmler();



        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Erhan Gündüz tarafından 26.01.2023 tarihinde geliştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRenkDegistir_Click(object sender, EventArgs e)
        {
            System.Drawing.Color[] renkler = { Color.LightSkyBlue, Color.DimGray, Color.Beige, Color.DarkGray, Color.WhiteSmoke, Color.DarkBlue };

            Random rnd = new Random();
            int renk = rnd.Next(renkler.Length);
            this.BackColor = renkler[renk];

        }

        private void BtnTamEkran_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            groupBox3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;


        }


        private void BtnNormal_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            groupBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Dock = DockStyle.Right;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
