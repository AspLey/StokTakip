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
    public partial class PersonelIslemSayfasi : Form
    {
        public PersonelIslemSayfasi()
        {
            InitializeComponent();
        }

        private void btnmarka_Click(object sender, EventArgs e)
        {
            MarkaSayfasi markaSayfasi = new MarkaSayfasi();
            this.Hide();
            markaSayfasi.Show();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            MusteriSayfasi musteriSayfasi = new MusteriSayfasi();
            this.Hide();
            musteriSayfasi.Show();
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            UrunSayfasi urunSayfasi = new UrunSayfasi();
            this.Hide();
            urunSayfasi.Show();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            StokSayfasi stokSayfasi = new StokSayfasi();
            this.Hide();
            stokSayfasi.Show();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            KategoriSayfasi kategoriSayfasi = new KategoriSayfasi();
            this.Hide();
            kategoriSayfasi.Show();
        }

        private void btnsatislar_Click(object sender, EventArgs e)
        {
            SatisSayfasi satisSayfasi = new SatisSayfasi();
            this.Hide();
            satisSayfasi.Show();
        }

        private void btnper_Click(object sender, EventArgs e)
        {
            StokGiris stokGiris = new StokGiris();
            this.Hide();
            stokGiris.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
