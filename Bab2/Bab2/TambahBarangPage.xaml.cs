using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab2.Models;
using Bab2.ViewModels;
using System.Collections.ObjectModel;

namespace Bab2
{
    public partial class TambahBarangPage : ContentPage
    {
        private ObservableCollection<Barang> myList;
        public TambahBarangPage(ObservableCollection<Barang> myList)
        {
            InitializeComponent();

            this.myList = myList;

            btnTambah.Clicked += BtnTambah_Clicked;
        }

        private async void BtnTambah_Clicked(object sender, EventArgs e)
        {
            var newBarang = (Barang)BindingContext;
            myList.Add(newBarang);

            await Navigation.PopAsync();
        }
    }
}
