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
    public partial class TambahBarangPage : ContentPage
    {
        private ListViewButtonViewModel myList;

        public TambahBarangPage(ListViewButtonViewModel myList)
        {
            InitializeComponent();

            this.myList = myList;

            btnTambah.Clicked += BtnTambah_Clicked;
        }

        private async void BtnTambah_Clicked(object sender, EventArgs e)
        {
            var newBarang = (Barang)BindingContext;

        }
    }
}
