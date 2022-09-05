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
    public partial class frmodemler : Form
    {
        public frmodemler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void frmodemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet3.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter1.Fill(this.yurtKayitDataSet3.Borclar);
            // TODO: This line of code loads data into the 'yurtKayitDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad,kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtad.Text = ad;
            txtsoyad.Text = soyad;
            txtkalan.Text = kalan;
            txtid.Text = id;


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            // odeme işlemini burada yaptım
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt16(txtodenen.Text );
            kalan = Convert.ToInt16(txtkalan.Text);
            yeniborc = kalan - odenen;
            txtkalan.Text = yeniborc.ToString();


            //yeni tutarı veri tabanına kaydetme

            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrId=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtid.Text);
            komut.Parameters.AddWithValue("@p1", txtkalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);



        }
    }
}
