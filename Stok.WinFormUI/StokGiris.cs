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
    public partial class StokGiris : Form
    {
        public StokGiris()
        {
            InitializeComponent();
        }

        StokDbContext stokDb = new StokDbContext();
        private void btnkayit_Click(object sender, EventArgs e)
        {

        }
        

        private void btnperskayit_Click(object sender, EventArgs e)
        {

        }
        

        private void btnpersgiris_Click(object sender, EventArgs e)
        {
            bilgiler.KULLANICIADI = tbxstokperskullanici.Text;
            bilgiler.SIFRE = tbxstokperssifre.Text;
            LoginYonetim yonetim = new LoginYonetim();
            //string kullanici;
            //string sifre;
            //kullanici = tbxstokperskullanici.Text;
            //sifre = tbxstokperssifre.Text;
            Personel pb = (from nesne in stokDb.Personels where nesne.KullaniciAdi == bilgiler.KULLANICIADI select nesne).FirstOrDefault();
            if (yonetim.Login(bilgiler.KULLANICIADI, bilgiler.SIFRE))
            {
                if (pb.Yetki == 1)
                {
                    //Admin İşlem Formunu Aç
                    
                    AdminSayfasi adminSayfasi = new AdminSayfasi();
                    this.Hide();
                    adminSayfasi.Show();


                }
                else if (pb.Yetki == 2)
                {
                    PersonelIslemSayfasi personelIslemSayfasi = new PersonelIslemSayfasi();
                    this.Hide();
                    personelIslemSayfasi.Show();
                }
                else
                {
                    MessageBox.Show("Geçersiz Yetki.");

                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı.");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Sifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (Sifregoster.CheckState == CheckState.Checked)
            {
                tbxstokperssifre.UseSystemPasswordChar = true;
                Sifregoster.Text = "Şifreyi Gizle";
            }
            else if (Sifregoster.CheckState == CheckState.Unchecked)
            {
                tbxstokperssifre.UseSystemPasswordChar = false;
                Sifregoster.Text = "Şifreyi Göster";
            }
        }
    }
}
