using Android.App;
using BuyMoreClient;
using BuyMoreClient.Droid;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PolicyListPage), typeof(PolicyListPageRenderer))]
namespace BuyMoreClient.Droid
{
    public class PolicyListPageRenderer : PageRenderer
    {
        private PolicyListPage _page;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            _page = e.NewElement as PolicyListPage;
            var activity = Context as Activity;
            _page.PlatformParameters = new PlatformParameters(activity);
        }
    }
}
