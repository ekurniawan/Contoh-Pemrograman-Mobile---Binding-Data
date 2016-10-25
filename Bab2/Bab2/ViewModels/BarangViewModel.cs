using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bab2.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Bab2.ViewModels
{
    public class BarangViewModel : BindableObject
    {
        private IList<Barang> listBarang;
        public IList<Barang> ListBarang
        {
            get { return listBarang; }
            set { listBarang = value; OnPropertyChanged("ListBarang"); }
        }


        public BarangViewModel()
        {
            ListBarang = new ObservableCollection<Barang>
            {
                new Barang {
                    KodeBarang = "BB001",
                    NamaBarang = "Busi NGK",
                    Deskripsi = "Busi NGK",
                    Jumlah = 45,
                    HargaBeli = 20000,
                    HargaJual = 25000
                },
                new Barang {
                    KodeBarang = "BB002",
                    NamaBarang = "Busi F1",
                    Deskripsi = "Busi F1",
                    Jumlah = 40,
                    HargaBeli = 20000,
                    HargaJual = 23000
                },
                new Barang {
                    KodeBarang = "BB003",
                    NamaBarang = "Busi Honda",
                    Deskripsi = "Busi Honda",
                    Jumlah = 22,
                    HargaBeli = 20000,
                    HargaJual = 22000
                }
            };
        }

    }
}
