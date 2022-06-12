using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Entities.Concrete.Tables
{
   public class Musteri
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public DateTime KayitTarihi { get; set; }


    }
}
