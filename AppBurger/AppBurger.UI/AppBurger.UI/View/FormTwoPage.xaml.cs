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
    public partial class FormTwoPage : ContentPage
    {
        public FormTwoPage()
        {
            InitializeComponent();
        }

        async void PrevPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormOnePage(), false);
        }
        async void HomePageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage(), false);
        }
    }
}