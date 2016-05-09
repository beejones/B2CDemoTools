using System;
using Microsoft.Identity.Client;

namespace BuyMoreClient
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public IPlatformParameters PlatformParameters { get; set; }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            App.PublicClientApplication.PlatformParameters = PlatformParameters;

            try
            {
                await App.PublicClientApplication.AcquireTokenSilentAsync(App.Scope);
            }
            catch
            {
            }
        }

        private async void LogInButton_OnClicked(object sender, EventArgs e)
        {
            var policyListPage = new PolicyListPage();
            await Navigation.PushAsync(policyListPage);
        }
    }
}
