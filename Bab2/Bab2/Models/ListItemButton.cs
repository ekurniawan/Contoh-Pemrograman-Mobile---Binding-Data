using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bab2.Models
{
    public class ListItemButton : BindableObject
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        private Command buyCommand;
        public Command BuyCommand
        {
            get { return buyCommand; }
            set { buyCommand = value; OnPropertyChanged("BuyCommand"); }
        }

        private Command sellCommand;
        public Command SellCommand
        {
            get { return sellCommand; }
            set { sellCommand = value; OnPropertyChanged("SellCommand"); }
        }

        public ListItemButton()
        {
            BuyCommand = new Command(BuyRequested);
            SellCommand = new Command(SellRequested);
        }

        private void SellRequested()
        {
            MessagingCenter.Send<ListItemButton>(this, "SellRequested");
        }

        private void BuyRequested()
        {
            MessagingCenter.Send<ListItemButton>(this, "BuyRequested");
        }
    }
}
