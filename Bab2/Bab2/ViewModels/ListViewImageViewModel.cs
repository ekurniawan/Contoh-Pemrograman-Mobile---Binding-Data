using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Bab2.Models;

namespace Bab2.ViewModels
{
    public class ListViewImageViewModel:BindableObject
    {
        private List<Mahasiswa> listItem;
        public List<Mahasiswa> ListItems
        {
            get { return listItem; }
            set
            {
                listItem = value;
                OnPropertyChanged("ListItems");
            }
        }

        public ListViewImageViewModel()
        {
            listItem = new List<Mahasiswa>
            {
                new Mahasiswa { Photo="photo_1.jpg",Name="Erick Kurniawan",
                    Description ="Dosen SI UKDW" },
                new Mahasiswa { Photo="photo_2.jpg",Name="Naga Gaotama",
                    Description ="Mahasiswa SI Angkatan 2007" },
                new Mahasiswa { Photo="photo_3.jpg",Name="Ardian Saputra",
                    Description ="Mahasiswa SI Angkatan 2007" }
            };
        }
    }
}
