using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab2.Models;

namespace Bab2
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Daftar Barang",
                IconSource = "icon.png",
                TargetType = typeof(TampilBarangPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Daftar List View",
                IconSource = "icon.png",
                TargetType = typeof(ListViewButton)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
