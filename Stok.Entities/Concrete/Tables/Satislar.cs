using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Entities.Concrete.Tables
{
    public class Satislar
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("urunler")]
        public int UrunId { get; set; }

        [ForeignKey("personel")]
        public int PersonelId { get; set; }

        [ForeignKey("musteri")]
        public int MusteriId { get; set; }

        public decimal SatisFiyati { get; set; }
        public DateTime Tarih { get; set; }
        public int SatisAdet { get; set; }

        public Urunler urunler { get; set; }
        public Personel personel { get; set; }
        public Musteri musteri { get; set; }
       
     




       


    }
}
