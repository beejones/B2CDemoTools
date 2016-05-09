using Android.App;
using BuyMoreClient;
using BuyMoreClient.Droid;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]
namespace BuyMoreClient.Droid
{
    public class MainPageRenderer : PageRenderer
    {
        private MainPage _page;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            _page = e.NewElement as MainPage;
            var activity = Context as Activity;
            _page.PlatformParameters = new PlatformParameters(activity);
        }
    }
}
