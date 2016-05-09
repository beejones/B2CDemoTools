using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace BuyMoreClient
{
    public partial class PolicyListPage : IPolicyListPage
    {
        public PolicyListPage()
        {
            InitializeComponent();
        }

        public IPlatformParameters PlatformParameters { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.PublicClientApplication.PlatformParameters = PlatformParameters;
            BindingContext = new PolicyListPageModel(this);
        }

        public async Task RunPolicyAsync(
            string authority,
            string[] scope,
            string policy)
        {
            try
            {
                await App.PublicClientApplication.AcquireTokenAsync(
                    scope,
                    string.Empty,
                    UiOptions.SelectAccount,
                    string.Empty,
                    null,
                    authority,
                    policy);
            }
            catch (MsalException ex)
            {
                if (ex.ErrorCode != "authentication_canceled")
                {
                    await DisplayError(ex);
                }
            }
            catch (Exception ex)
            {
                await DisplayError(ex);
            }
        }

        private Task DisplayError(Exception exception)
        {
            return DisplayAlert("An unexpected error has occurred", exception.Message, "Dismiss");
        }
    }
}
