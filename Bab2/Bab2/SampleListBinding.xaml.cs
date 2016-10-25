using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab2.Models;
using Bab2.ViewModels;

namespace Bab2
{
    public partial class SampleListBinding : ContentPage
    {
        public SampleListBinding()
        {
            InitializeComponent();
            BindingContext = new ListItemViewModel();


        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var result = (ListItem)e.SelectedItem;
            DisplayAlert("Keterangan", "Anda memilih: " + result.Title + "-" + result.Description,"OK");
        }
    }
}
