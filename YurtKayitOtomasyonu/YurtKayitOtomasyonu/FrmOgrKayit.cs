using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YurtKayitOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bölümleri Lİsteleme Komutları
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                cmbbolum.Items.Add(oku[0].ToString());


            }
            bgl.baglanti().Close();
            // boş odaları listeleme komutları 
       
            SqlCommand komut2 = new SqlCommand("Select OdaNo  from Odalar where OdaKapasite != OdaAktif",bgl. baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                cmbodano.Items.Add(oku2[0].ToString());
            }

            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            // Ögrenci Bilgilerinin Kayıt edilme Komutları
            try
            {

                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtograd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", msktc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", msktelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskdtarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbbolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtmail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbodano.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtveli.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskvelitelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchadres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde gerçekleşti.");

                SqlCommand komut = new SqlCommand("select OgrId from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();



                // Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar values (OgrId,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtograd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtsoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }



            catch (Exception)
            {
                MessageBox.Show("Hata");

            }


        }
    }
}
//Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;Initial Catalog=YurtKayit;Integrated Security=True
