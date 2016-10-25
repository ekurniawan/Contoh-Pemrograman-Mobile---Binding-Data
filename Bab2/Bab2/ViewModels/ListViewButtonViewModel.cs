using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Bab2.Models;
using System.Collections.ObjectModel;

namespace Bab2.ViewModels
{
    public class ListViewButtonViewModel : BindableObject
    {
        //Func<string, string, string, Task> displayAlertAction;
        Func<Page, Task> displayPage;

        private IList<ListItemButton> listItems;
        public IList<ListItemButton> ListItems
        {
            get { return listItems; }
            set { listItems = value; OnPropertyChanged("ListItems"); }
            
        }

        /*public ListViewButtonViewModel(Func<string,string,string,Task> displayAlertAction)
        {
            this.displayAlertAction = displayAlertAction;
            ListItems = new List<ListItemButton>
            {
                new ListItemButton { Title="ASP.NET MVC",
                    Description ="EBook ASP.NET MVC",Price=60000 },
                new ListItemButton { Title="Xamarin Android",
                    Description="EBook Xamarin Android", Price=75000},
                new ListItemButton {Title="Xamarin IOS",
                    Description ="EBook Xamarin IOS",Price=80000 }
            };

            MessagingCenter.Subscribe<ListItemButton>(this, "BuyRequested", BuyRequested);
        }*/

        public ListViewButtonViewModel(Func<Page,Task> displayPage)
        {
            this.displayPage = displayPage;
            ListItems = new ObservableCollection<ListItemButton>
            {
                new ListItemButton { Title="ASP.NET MVC",
                    Description ="EBook ASP.NET MVC",Price=60000 },
                new ListItemButton { Title="Xamarin Android",
                    Description="EBook Xamarin Android", Price=75000},
                new ListItemButton {Title="Xamarin IOS",
                    Description ="EBook Xamarin IOS",Price=80000 }
            };

            //MessagingCenter.Subscribe<ListItemButton>(this, "BuyRequested", BuyRequested);
            MessagingCenter.Subscribe<ListItemButton>(this, "BuyRequested", DisplayPageRequested);
        }

        private void DisplayPageRequested(ListItemButton obj)
        {
            displayPage.Invoke(new KonfirmasiBeliPage(obj));
        }

        /*private void BuyRequested(ListItemButton obj)
        {
            displayAlertAction.Invoke("Konfirmasi Beli", "Anda membeli item: " +
                obj.Title + " dengan harga: Rp." + obj.Price.ToString(), "OK"); 
        }*/
    }
}
