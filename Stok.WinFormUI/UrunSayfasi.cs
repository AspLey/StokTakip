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
    public partial class UrunSayfasi : Form
    {
        public UrunSayfasi()
        {
            InitializeComponent();
        }

        UrunlerYonetim urunYonetim = new UrunlerYonetim();
        StokDbContext Context = new StokDbContext();
        private void UrunSayfasi_Load(object sender, EventArgs e)
        {
            listele();
            markacbx();
            kategoricbx();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;


        }

        private void urunekle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler()
            {
                UrunAdi = Uruneklead.Text,
                MarkaId = (int)Urunmarka.SelectedValue,
                KategoriId = (int)UrunKategori.SelectedValue,
                AlısFiyati = int.Parse(UrunAlis.Text),
                SatisFiyati = int.Parse(UrunSatis.Text),
                Tarih = UrunTarih.Value
            };
            urunYonetim.Add(u);
            listele();
        }
        public void listele()
        {
            dataGridView1.DataSource = urunYonetim.Listele();
        }
        public void markacbx()
        {
            var marka = Context.Markalars.ToList();
            Urunmarka.DataSource = marka;
            Urunmarka.DisplayMember = "Marka";
            Urunmarka.ValueMember = "Id";

            Urunguncelmarka.DataSource = marka;
            Urunguncelmarka.DisplayMember = "Marka";
            Urunguncelmarka.ValueMember = "Id";
        }
        public void kategoricbx()
        {
            var kategori = Context.Kategorilers.ToList();
            //var kategori = Context.Database.SqlQuery<>("");

            UrunKategori.DataSource = kategori;
            UrunKategori.DisplayMember = "KategoriAdi";
            UrunKategori.ValueMember = "Id";

            urunguncelkategori.DataSource = kategori;
            urunguncelkategori.DisplayMember = "KategoriAdi";
            urunguncelkategori.ValueMember = "Id";
        }

        private void urunsilme_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler()
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value
            };
            urunYonetim.Delete(u);
            listele();
        }

        private void urunguncel_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler()
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                UrunAdi = urungunceladi.Text,
                MarkaId = (int)Urunguncelmarka.SelectedValue,
                KategoriId = (int)urunguncelkategori.SelectedValue,
                AlısFiyati = Convert.ToDecimal(urunguncelalis.Text),
                SatisFiyati = Convert.ToDecimal(urunguncelsatis.Text),
                Tarih = urungunceltarih.Value
            };
            urunYonetim.Update(u);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urungunceladi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            urunguncelalis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            urunguncelsatis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            urungunceltarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void uruntemiz_Click(object sender, EventArgs e)
        {
            Uruneklead.Clear();
            UrunAlis.Clear();
            UrunSatis.Clear();
            urungunceladi.Clear();
            urunguncelalis.Clear();
            urunguncelsatis.Clear();

        }

        private void urungeridon_Click(object sender, EventArgs e)
        {
            PersonelIslemSayfasi personelIslemSayfasi = new PersonelIslemSayfasi();
            this.Hide();
            personelIslemSayfasi.Show();
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

        private void urunarama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunYonetim.Search(urunarama.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
