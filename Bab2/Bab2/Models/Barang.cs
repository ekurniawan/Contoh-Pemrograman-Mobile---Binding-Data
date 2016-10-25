using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab2.Models
{
    public class Barang
    {
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Deskripsi { get; set; }
        public int Jumlah { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
    }
}
