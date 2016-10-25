using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab2.ViewModels;
using Bab2.Models;

namespace Bab2
{
    public partial class TampilBarangPage : ContentPage
    {
        private BarangViewModel barangViewModel;
        public TampilBarangPage()
        {
            InitializeComponent();

            barangViewModel = new BarangViewModel();
            BindingContext = barangViewModel;

            btnTambah.Clicked += BtnTambah_Clicked;
        }


        private async void BtnTambah_Clicked(object sender, EventArgs e)
        {
            var tambahPage = new TambahBarangPage(barangViewModel.ListBarang);
            tambahPage.BindingContext = new Barang();
            await Navigation.PushAsync(tambahPage);
        }
    }
}
