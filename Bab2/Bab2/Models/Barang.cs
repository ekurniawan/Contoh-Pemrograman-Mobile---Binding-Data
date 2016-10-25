using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab2.Models
{
    public class Barang : BindableObject
    {
        private string kodeBarang;
        public string KodeBarang
        {
            get { return kodeBarang; }
            set { kodeBarang = value; OnPropertyChanged("KodeBarang"); }
        }

        private string namaBarang;
        public string NamaBarang
        {
            get { return namaBarang; }
            set { namaBarang = value; OnPropertyChanged("NamaBarang"); }
        }

        private string deskripsi;
        public string Deskripsi
        {
            get { return deskripsi; }
            set { deskripsi = value; OnPropertyChanged("Deskripsi"); }
        }

        private int jumlah;
        public int Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; OnPropertyChanged("Jumlah"); }
        }

        private decimal hargaBeli;
        public decimal HargaBeli
        {
            get { return hargaBeli; }
            set { hargaBeli = value; OnPropertyChanged("HargaBeli"); }
        }

        private decimal hargaJual;
        public decimal HargaJual
        {
            get { return hargaJual; }
            set { hargaJual = value; OnPropertyChanged("HargaJual"); }
        }

    }
}
