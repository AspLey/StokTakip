using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Entities.Concrete.Tables
{
   public  class Personel
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string KullaniciAdi { get; set; }
        public string sifre { get; set; }

        [ForeignKey("yetki")]
        public int Yetki { get; set; }
        public Yetki yetki { get; set; }

    }
}
