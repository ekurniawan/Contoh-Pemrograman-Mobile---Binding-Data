using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bab2.Models;
using Xamarin.Forms;

namespace Bab2.ViewModels
{
    public class ListViewCustomViewModel : BindableObject
    {
        private List<Barang> listItems;
        public List<Barang> ListItems
        {
            get { return listItems; }
            set
            {
                listItems = value;
                OnPropertyChanged("ListItems");
            }
        }

        public ListViewCustomViewModel()
        {
            listItems = new List<Barang>
            {
                new Barang { KodeBarang="MM001",NamaBarang="Monitor Samsung",Deskripsi="Monitor samsung terbaru",
                Jumlah=10,HargaBeli=1500000,HargaJual=2000000},
                new Barang { KodeBarang="MM002",NamaBarang="Monitor LG",Deskripsi="Monitor plasma",
                Jumlah=15,HargaBeli=1500000,HargaJual=2100000},
                new Barang { KodeBarang="MM003",NamaBarang="Monitor Sony",Deskripsi="Monitor Sony terbaru",
                Jumlah=20,HargaBeli=2000000,HargaJual=3000000},
            };
        }

    }
}
