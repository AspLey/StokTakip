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
    public partial class MusteriSayfasi : Form
    {
        public MusteriSayfasi()
        {
            InitializeComponent();
        }
        StokDbContext context = new StokDbContext();
        MusteriYonetim Musteriler = new MusteriYonetim();
        private void musteriekle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri()
            {
                AdSoyad = MusteriAdSoyad.Text,
                Telefon = MusteriTel.Text,
                Adres = MusteriAdres.Text,
                Mail = MusteriMail.Text,
                KayitTarihi = MusteriTarih.Value
            };
            Musteriler.Add(m);
            Listele();
        }
        public void Listele()
        {
            dataGridView1.DataSource = Musteriler.Listele();
        }

        private void MusteriSayfasi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void musterisil_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value

            };
            Musteriler.Delete(m);
            Listele();
        }

        private void musteriguncel_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                AdSoyad = MusteriGuncelad.Text,
                Telefon=MusteriguncelTel.Text,
                Adres=MusteriGuncelAdres.Text,
                Mail=MusteriGuncelMail.Text,
                KayitTarihi=MusteriGuncelTarih.Value

            };
            Musteriler.Update(m);
            Listele();
        }

        private void musteritemizle_Click(object sender, EventArgs e)
        {
            
            MusteriAdSoyad.Clear();
            MusteriTel.Clear();
            MusteriAdres.Clear();
            MusteriGuncelad.Clear();
            MusteriguncelTel.Clear();
            MusteriGuncelAdres.Clear();
            MusteriMail.Clear();
            MusteriGuncelMail.Clear();
            MusteriAdSoyad.Focus();
           


        }

        private void musterigeridön_Click(object sender, EventArgs e)
        {
            PersonelIslemSayfasi personelIslemSayfasi = new PersonelIslemSayfasi();
            this.Hide();
            personelIslemSayfasi.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriGuncelad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MusteriguncelTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MusteriGuncelAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MusteriGuncelMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MusteriGuncelTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
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

        private void MusteriArama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Musteriler.Search(MusteriArama.Text);
        }
    }
}
