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
    public partial class ListViewButton : ContentPage
    {
        private ListViewButtonViewModel myList;

        public ListViewButton()
        {
            InitializeComponent();
            myList = new ListViewButtonViewModel(Navigation.PushAsync);

            BindingContext = myList;
            btnTambah.Clicked += BtnTambah_Clicked;
        }

        private async void BtnTambah_Clicked(object sender, EventArgs e)
        {
            //myList.ListItems.Add(new ListItemButton { Title = "Test", Description = "Test", Price = 2000 });
            await Navigation.PushAsync(new TambahBarangPage());
        }
    }
}
