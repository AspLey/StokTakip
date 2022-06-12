using Stok.Business.Concrete;
using Stok.DataAccess.Concrete;
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
    public partial class StokSayfasi : Form
    {
        public StokSayfasi()
        {
            InitializeComponent();
        }
        StokYonetim stoklar = new StokYonetim();
        StokDbContext Context = new StokDbContext();
        private void stokekleme_Click(object sender, EventArgs e)
        {
            Entities.Concrete.Tables.Stok s = new Entities.Concrete.Tables.Stok()
            {
                UrunId=(int)stokurun.SelectedValue,
                MarkaId=(int)stokmarka.SelectedValue,
                KategoriId=(int)stokkategori.SelectedValue,
                StokAdeti=Convert.ToInt32(stokadet.Text),
                StokTarih=stoktarih.Value

            };
            stoklar.Add(s);
            listele();

        }

        public void listele()
        {
            dataGridView1.DataSource = stoklar.Listele();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Urun ismi";

        }

        private void StokSayfasi_Load(object sender, EventArgs e)
        {
            listele();
            uruncbx();
            markacbx();
            kategoricbx();
        }

        public void uruncbx()
        {
            var urun = Context.Urunlers.ToList();
            stokurun.DataSource = urun;
            stokurun.DisplayMember = "UrunAdi";
            stokurun.ValueMember = "Id";

            stokguncelurun.DataSource = urun;
            stokguncelurun.DisplayMember = "UrunAdi";
            stokguncelurun.ValueMember = "Id";

        }
        public void markacbx()
        {
            var marka = Context.Markalars.ToList();
            stokmarka.DataSource = marka;
            stokmarka.DisplayMember = "Marka";
            stokmarka.ValueMember = "Id";

            stokguncelmarka.DataSource = marka;
            stokguncelmarka.DisplayMember = "Marka";
            stokguncelmarka.ValueMember = "Id";
        }
        public void kategoricbx()
        {
            var kategori = Context.Kategorilers.ToList();

            stokkategori.DataSource = kategori;
            stokkategori.DisplayMember = "KategoriAdi";
            stokkategori.ValueMember = "Id";

            stokguncelkategori.DataSource = kategori;
            stokguncelkategori.DisplayMember = "KategoriAdi";
            stokguncelkategori.ValueMember = "Id";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //stokguncelurun.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            //stokguncelmarka.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value;
            //stokguncelkategori.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            stokgunceladet.Text =dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void stoksil_Click(object sender, EventArgs e)
        {
            Entities.Concrete.Tables.Stok s = new Entities.Concrete.Tables.Stok()
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value
            };
            stoklar.Delete(s);
            listele();
        }

        private void stokguncel_Click(object sender, EventArgs e)
        {
            Entities.Concrete.Tables.Stok m = new Entities.Concrete.Tables.Stok()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                UrunId= (int)stokguncelurun.SelectedValue,
                MarkaId= (int)stokguncelmarka.SelectedValue,
                KategoriId= (int)stokguncelmarka.SelectedValue,
                StokAdeti=Convert.ToInt32(stokgunceladet.Text),
                StokTarih=stokgunceltarih.Value


            };
            stoklar.Update(m);
            listele();
        }

        private void stoktemizle_Click(object sender, EventArgs e)
        {
            stokadet.Clear();
            stokgunceladet.Clear();

        }

        private void stokgeridon_Click(object sender, EventArgs e)
        {
            PersonelIslemSayfasi personelIslemSayfasi = new PersonelIslemSayfasi();
            this.Hide();
            personelIslemSayfasi.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
