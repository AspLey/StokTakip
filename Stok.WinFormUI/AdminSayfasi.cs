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
    public partial class AdminSayfasi : Form
    {
        public AdminSayfasi()
        {
            InitializeComponent();
        }

        private void btnperson_Click(object sender, EventArgs e)
        {
            PersonelSayfasi personel = new PersonelSayfasi();
            this.Hide();
            personel.Show();
        }

        private void müsterisayfasi_Click(object sender, EventArgs e)
        {
            MusteriSayfasi musteri = new MusteriSayfasi();
            this.Hide();
            musteri.Show();
        }

        private void ürünsayfasi_Click(object sender, EventArgs e)
        {
            UrunSayfasi urunSayfasi = new UrunSayfasi();
            this.Hide();
            urunSayfasi.Show();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            StokSayfasi stok = new StokSayfasi();
            this.Hide();
            stok.Show();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            SatisSayfasi satisSayfasi = new SatisSayfasi();
            this.Hide();
            satisSayfasi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokGiris stokGiris = new StokGiris();
            this.Hide();
            stokGiris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
