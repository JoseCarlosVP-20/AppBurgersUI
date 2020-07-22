using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBurger.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PushAsync(new FormOnePage(), false);
        }
    }
}