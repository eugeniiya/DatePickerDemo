using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatePickerDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }
        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
            (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);
            resultLabel.Text = String.Format("{0}", timeSpan.Days);
        }
    }
}
