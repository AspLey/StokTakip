using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stok.Entities.Concrete.Tables
{
   public class Markalar
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Kategoriler")]
        public int KategoriId { get; set; }
        public string Marka { get; set; }
        public string Aciklama { get; set; }

        public Kategoriler Kategoriler { get; set; }
       

    }
}
