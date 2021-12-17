using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace letshoop.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=7uBqNgxAuBA&ab_channel=hahahailey"));
        }

        public ICommand OpenWebCommand { get; }
    }
}