using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Entities.Concrete.Tables
{
    public class Kategoriler
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

       

    }
}
