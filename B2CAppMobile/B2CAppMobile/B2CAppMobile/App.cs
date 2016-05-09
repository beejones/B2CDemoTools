using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace BuyMoreClient
{
    public class App : Application
    {
        public static string Authority = "https://login.microsoftonline.com/b2ccharm.onmicrosoft.com";
        public static string ClientId = "7393f3b7-7c95-490e-b854-5cae8b7d160a";
        public static PolicyInfo[] Policies;
        public static PublicClientApplication PublicClientApplication;
        public static string[] Scope = { ClientId };

        public App()
        {
            PublicClientApplication = new PublicClientApplication(Authority, ClientId);
            InitializePolicies();
            var mainPage = new MainPage();
            MainPage = new NavigationPage(mainPage);
        }

        private static PolicyInfo CreatePolicy(string caption, string policy)
        {
            return new PolicyInfo(
                Authority,
                caption,
                policy,
                Scope);
        }

        private static void InitializePolicies()
        {
            Policies = new[]
            {
                CreatePolicy("AAD B2C", "B2C_1_BuyMoreUsers"),
                CreatePolicy("AAD B2C + REST API", "B2C_1A_SignupWithRest"),
                CreatePolicy("AAD B2C + BYO IdP + REST API", "B2C_1A_SignupWithRestAndIdp")
            };
        }
    }
}
