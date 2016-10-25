using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Bab2.Models;

namespace Bab2.ViewModels
{
    public class ListItemViewModel : BindableObject
    {
        private List<ListItem> listItems;
        public List<ListItem> ListItems
        {
            get { return listItems; }
            set { listItems = value; OnPropertyChanged("ListItems"); }
        }


        public ListItemViewModel()
        {
            listItems = new List<ListItem>
            {
                new ListItem {Title="Xamarin Form",
                    Description ="Cross Platform Mobile Dev dengan C#"},
                new ListItem {Title="Xamarin Android",
                    Description ="Xamarin spesifik untuk platform Android native" },
                new ListItem {Title="Xamarin IOS",
                    Description ="Xamarin spesifik untuk platform IOS"}
            };
        }
    }
}
