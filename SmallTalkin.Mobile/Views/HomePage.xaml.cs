using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmallTalkin.Mobile
{
    public partial class HomePage : ContentPage
    {
        HomePageViewModel viewModel;

        public HomePage()
        {
			InitializeComponent();

            BindingContext = viewModel = new HomePageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
