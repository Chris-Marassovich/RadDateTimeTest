using RadDateTimeTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RadDateTimeTest.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}