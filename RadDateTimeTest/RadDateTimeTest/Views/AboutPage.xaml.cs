using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RadDateTimeTest.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            myDateTimePicker.DefaultHighlightedDate = DateTime.Now;
        }

        public ICommand MyClearCommand => new Command(() => { myDateTimePicker.ClearCommand.Execute(null); myDateTimePicker.ToggleCommand.Execute(null); });
    }
}