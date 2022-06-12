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
    public partial class PersonelSayfasi : Form
    {
        public PersonelSayfasi()
        {
            InitializeComponent();
        }

        PersonelYonetim Personeller = new PersonelYonetim();
        StokDbContext context = new StokDbContext();
        private void personelekle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel()
            {
                AdSoyad=personeladsoyad.Text,
                Adres=personeladres.Text,
                Maas=personelmaas.Text,
                KullaniciAdi=personelkullanici.Text,
                sifre=personelsifre.Text,
                Yetki=(int)personelyetki.SelectedValue
            };
            Personeller.Add(p);
            listele();
            
        }


        public void listele()
        {
            dataGridView1.DataSource = Personeller.Listele();
            dataGridView1.Columns[7].Visible = false;
        }

        private void PersonelSayfasi_Load(object sender, EventArgs e)
        {


            listele();
            doldur();
        }

        private void personelsil_Click(object sender, EventArgs e)
        {
            Personel p = new Personel()
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value
            };
            Personeller.Delete(p);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            personelguncelad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            personelgunceladres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            personelguncelmaas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            personelguncelkullanici.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            personelguncelsifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void personelguncel_Click(object sender, EventArgs e)
        {
            var update = context.Personels.Find(dataGridView1.CurrentRow.Cells[0].Value);
            update.AdSoyad = personelguncelad.Text;
            update.Adres = personelgunceladres.Text;
            update.Maas = personelguncelmaas.Text;
            update.KullaniciAdi = personelguncelkullanici.Text;
            update.sifre = personelguncelsifre.Text;
            Personeller.Update(update);
            listele();
        }

        private void personeltemiz_Click(object sender, EventArgs e)
        {
            personeladsoyad.Clear();
            personeladres.Clear();
            personelmaas.Clear();
            personelkullanici.Clear();
            personelsifre.Clear();
            personelguncelad.Clear();
            personelgunceladres.Clear();
            personelguncelmaas.Clear();
            personelguncelkullanici.Clear();
            personelguncelsifre.Clear();
        }

        private void personelgeridön_Click(object sender, EventArgs e)
        {
            PersonelIslemSayfasi personelIslemSayfasi = new PersonelIslemSayfasi();
            this.Hide();
            personelIslemSayfasi.Show();
        }

        public void doldur()
        {
            var kategori = context.yetkis.ToList();
            personelyetki.DataSource = kategori;
            personelyetki.DisplayMember = "Ad";
            personelyetki.ValueMember = "Id";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personelarama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Personeller.Search(personelarama.Text);
        }
    }
}
