using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab2
{
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();

            List<string> items =
                new List<string> { "Android Studio", "Visual Studio", "VS Code", "Web Storm" };
            listView.ItemsSource = items;

            listView.ItemTapped += ListView_ItemTapped;
            listView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Keterangan","Anda memilih item: " + e.Item.ToString(),"OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}
