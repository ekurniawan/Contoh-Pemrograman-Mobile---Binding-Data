using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab2
{
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();

            btnDua.Clicked += BtnDua_Clicked;
        }

        protected async void Navigate(object sender, EventArgs e)
        {
            var item = (ToolbarItem)sender;
            string type = item.CommandParameter.ToString();
            Type pageType = Type.GetType("Bab2." + type + ",Bab2");
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);
        }

        private async void BtnDua_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2(txtNama.Text));
        }
    }
}
