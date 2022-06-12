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
    public partial class MarkaSayfasi : Form
    {
        public MarkaSayfasi()
        {
            InitializeComponent();
        }
        MarkalarYonetim Marka = new MarkalarYonetim();
        StokDbContext context = new StokDbContext();
        private void markaekle_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar()
            {

                Marka = txteklemarka.Text,
                Aciklama = txtekleacik.Text,
                KategoriId = (int)cbxeklekategori.SelectedValue


            };
            Marka.Add(m);
            Listele();
            
        }

        private void MarkaSayfasi_Load(object sender, EventArgs e)
        {
            Listele();
            var kategori = context.Kategorilers.ToList();
            cbxeklekategori.DataSource = kategori;
            cbxeklekategori.DisplayMember = "KategoriAdi";
            cbxeklekategori.ValueMember = "Id";

            cbxguncelkategori.DataSource = kategori;
            cbxguncelkategori.DisplayMember = "KategoriAdi";
            cbxguncelkategori.ValueMember = "Id";
        }
        private void Listele()
        {
            dataGridView1.DataSource = Marka.Listele();
            dataGridView1.Columns[4].Visible = false;
        }

        private void markasil_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value

            };
            Marka.Delete(m);
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtguncelmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtguncelacik.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void markaguncel_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar()
            {

                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                KategoriId = (int)cbxguncelkategori.SelectedValue,
                Marka = txtguncelmarka.Text,
                Aciklama = txtguncelacik.Text

            };
            Marka.Update(m);
            Listele();
        }

        private void markatemizle_Click(object sender, EventArgs e)
        {
            txtekleacik.Clear();
            txteklemarka.Clear();
            txtguncelacik.Clear();
            txtguncelmarka.Clear();
        }

        private void markageridon_Click(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Marka.Search(markasearch.Text);
        }
    }
}
