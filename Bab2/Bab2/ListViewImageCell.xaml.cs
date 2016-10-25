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
    public partial class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            InitializeComponent();
            BindingContext = new ListViewImageViewModel();
            listView.ItemTapped += ListView_ItemTapped;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Mahasiswa mhs = (Mahasiswa)e.Item;
            await DisplayAlert("Keterangan", "Anda memilih : " +
                mhs.Name, "OK"); 
        }
    }
}
