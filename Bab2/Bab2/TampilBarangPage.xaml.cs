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

            listBarang.ItemTapped += ListBarang_ItemTapped;
        }

        async void Navigate(object sender,EventArgs e)
        {
            string type = (string)((ToolbarItem)sender).CommandParameter;
            Type pageType = Type.GetType("Bab2." + type + ",Bab2");
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);

        }

        private async void ListBarang_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var itemBarang = (Barang)e.Item;
            var editPage = new EditBarangPage();
            editPage.BindingContext = itemBarang;
            await Navigation.PushAsync(editPage);
        }

        private async void BtnTambah_Clicked(object sender, EventArgs e)
        {
            var tambahPage = new TambahBarangPage(barangViewModel.ListBarang);
            tambahPage.BindingContext = new Barang();
            await Navigation.PushAsync(tambahPage);
        }
    }
}
