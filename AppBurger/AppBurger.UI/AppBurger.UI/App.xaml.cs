using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBurger.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
            //MainPage = new FormOnePage();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
