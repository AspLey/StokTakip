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
    public partial class SatisSayfasi : Form
    {
        public SatisSayfasi()
        {
            InitializeComponent();
        }
        SatislarYonetim satislar = new SatislarYonetim();
        StokDbContext context = new StokDbContext();
        StokYonetim stoklar = new StokYonetim();
        private void satiekle_Click(object sender, EventArgs e)
        {
            Satislar s = new Satislar()
            {
                UrunId=(int)satisurun.SelectedValue,
                SatisFiyati=Convert.ToDecimal(satisfiyat.Text),
                Tarih=satistarih.Value,
                MusteriId=(int)satismüsteri.SelectedValue,
                PersonelId=(int)satispersonel.SelectedValue,
                SatisAdet=Convert.ToInt32(satisadet.Text)
            };
            Entities.Concrete.Tables.Stok sts = (from nesne in context.Stoks where nesne.UrunId == (int)satisurun.SelectedValue select nesne).FirstOrDefault();
            sts.StokAdeti -= int.Parse(satisadet.Text);
            var stk = context.Stoks.Find(sts.Id);
            stk.StokAdeti = sts.StokAdeti;
            stk.UrunId = sts.UrunId;
            stk.MarkaId = sts.MarkaId;
            stk.KategoriId = sts.KategoriId;
            stk.StokTarih = sts.StokTarih;

            stoklar.Update(stk);

            satislar.Add(s);
            listele();

        }
        public void listele()
        {
            dataGridView1.DataSource = satislar.Listele();
        
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }


        public void uruncbx()
        {
            var urun = context.Urunlers.ToList();
            satisurun.DataSource = urun;
            satisurun.DisplayMember = "UrunAdi";
            satisurun.ValueMember = "Id";
        }
        public void mustericbx()
        {
            var musteri = context.Musteris.ToList();
            satismüsteri.DataSource = musteri;
            satismüsteri.DisplayMember = "AdSoyad";
            satismüsteri.ValueMember = "Id";
        }
        public void personelcbx()
        {
            var personel = context.Personels.ToList();
            satispersonel.DataSource = personel;
            satispersonel.DisplayMember = "AdSoyad";
            satispersonel.ValueMember = "Id";
        }

        private void satissilme_Click(object sender, EventArgs e)
        {
            Satislar s = new Satislar()
            {
                Id=(int)dataGridView1.CurrentRow.Cells[0].Value
            };
            satislar.Delete(s);
            listele();
        }

        private void satistemizle_Click(object sender, EventArgs e)
        {
            satisfiyat.Clear();
        }

        private void satisdön_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SatisSayfasi_Load(object sender, EventArgs e)
        {
            listele();
            uruncbx();
            mustericbx();
            personelcbx();

        }
    }
}
