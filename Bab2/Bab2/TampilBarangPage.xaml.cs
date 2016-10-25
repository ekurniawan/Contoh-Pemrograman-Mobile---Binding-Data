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
        public TampilBarangPage()
        {
            InitializeComponent();

            BindingContext = new BarangViewModel();
        }
    }
}
