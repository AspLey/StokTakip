using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Entities.Concrete.Tables
{
   public class Stok
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("urunler")]
        public int UrunId { get; set; }

        [ForeignKey("markalar")]
        public int MarkaId { get; set; }

        [ForeignKey("Kategoriler")]
        public int KategoriId { get; set; }
        public int StokAdeti { get; set; }
        public DateTime StokTarih { get; set; }

        public  Urunler urunler { get; set; }
        public  Markalar markalar { get; set; }
        public  Kategoriler Kategoriler { get; set; }
    }
}
