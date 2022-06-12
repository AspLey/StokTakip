using Stok.Business.Concrete;
using Stok.DataAccess.Concrete;
using Stok.Entities.Concrete.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok.WinFormUI
{
    public partial class KategoriSayfasi : Form
    {
        public KategoriSayfasi()
        {
            InitializeComponent();
        }

        KategorilerYonetim kategori = new KategorilerYonetim();
        StokDbContext context = new StokDbContext();

        private void kategoriekle_Click(object sender, EventArgs e)
        {
            Kategoriler ktg = new Kategoriler() {

                KategoriAdi = txtkategoriadi.Text,
                Aciklama = txtkategoriacikla.Text
                
            };
            kategori.Add(ktg);
            Listele();
            
            
        }

      

        private void KategoriSayfasi_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            dataGridView1.DataSource = kategori.Listele();
            

        }

        private void kategorisil_Click(object sender, EventArgs e)
        {
            Kategoriler ktg = new Kategoriler()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value

            };
            kategori.Delete(ktg);
            Listele();
        }

        private void kategoriguncel_Click(object sender, EventArgs e)
        {
            Kategoriler ktg = new Kategoriler()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                KategoriAdi = txtkategoriadguncel.Text,
                Aciklama=txtkategoriguncelacik.Text
            };
            kategori.Update(ktg);
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkategoriadguncel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtkategoriguncelacik.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        public void temizle()
        {
            txtkategoriacikla.Clear();
            txtkategoriadguncel.Clear();
            txtkategoriadi.Clear();
            txtkategoriguncelacik.Clear();
        }

        private void kategoritemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void kategoridon_Click(object sender, EventArgs e)
        {
            PersonelIslemSayfasi personelIslem = new PersonelIslemSayfasi();
            this.Hide();
            personelIslem.Show();
            
        }

        private void txtkategorisearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=kategori.Search(txtkategorisearch.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelIslemSayfasi personelIslemSayfasi = new PersonelIslemSayfasi();
            this.Hide();
            personelIslemSayfasi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSayfasi adminSayfasi = new AdminSayfasi();
            this.Hide();
            adminSayfasi.Show();
        }
    }
}
