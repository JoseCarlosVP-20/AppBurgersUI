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
    public partial class FormOnePage : ContentPage
    {
        public FormOnePage()
        {
            InitializeComponent();
        }
        async void NextPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PushAsync(new FormTwoPage(), false);
        }
    }
}