using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab2
{
    public partial class SelectionView : ContentPage
    {
        public SelectionView()
        {
            InitializeComponent();

            var options = new List<string> { "Erick", "Budi", "Bambang", "Joko", "Amir" };
            foreach(var nama in options)
            {
                picker.Items.Add(nama);
            }

            picker.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                pageValue.Text = picker.Items[picker.SelectedIndex];
            };

            //mengambil nilai dari datepicker
            datePicker.DateSelected += DatePicker_DateSelected;

            timePicker.PropertyChanged += TimePicker_PropertyChanged;

            stepper.ValueChanged += Stepper_ValueChanged;

            slider.ValueChanged += Slider_ValueChanged;

            switcher.Toggled += Switcher_Toggled;
        }

        private void Switcher_Toggled(object sender, ToggledEventArgs e)
        {
            eventValue.Text = string.Format("Switch is now {0}", e.Value);
            pageValue.Text = switcher.IsToggled.ToString();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            eventValue.Text = string.Format("Slider value is {0}", e.NewValue);
            pageValue.Text = slider.Value.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            eventValue.Text = string.Format("Stepper value is {0:F1}", e.NewValue);
            pageValue.Text = stepper.Value.ToString();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName==TimePicker.TimeProperty.PropertyName)
            {
                pageValue.Text = timePicker.Time.ToString();
            }
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            eventValue.Text = e.NewDate.ToString();
            pageValue.Text = datePicker.Date.ToString();
        }
    }
}
