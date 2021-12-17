using letshoop.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace letshoop.Views
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