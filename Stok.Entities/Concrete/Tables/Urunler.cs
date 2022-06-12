using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Entities.Concrete.Tables
{
   public class Urunler
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("kategoriler")]
        public int KategoriId { get; set; }

        [ForeignKey("markalar")]
        public int MarkaId { get; set; }
        public string UrunAdi { get; set; }
        public decimal AlısFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public DateTime Tarih { get; set; }

        public Kategoriler kategoriler { get; set; }
        public Markalar markalar { get; set; }
        

    }
}
