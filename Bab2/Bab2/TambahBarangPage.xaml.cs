using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab2.Models;

namespace Bab2
{
    public partial class TambahBarangPage : ContentPage
    {
        public TambahBarangPage()
        {
            InitializeComponent();

            btnTambah.Clicked += BtnTambah_Clicked;
        }

        private async void BtnTambah_Clicked(object sender, EventArgs e)
        {
            Barang newBarang = new Barang
            {
                KodeBarang = 
            }
        }
    }
}
