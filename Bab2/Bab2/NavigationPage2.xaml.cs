using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab2
{
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2(string nama)
        {
            InitializeComponent();

            lblNama.Text = nama;

            btnBack.Clicked += BtnBack_Clicked;
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}
