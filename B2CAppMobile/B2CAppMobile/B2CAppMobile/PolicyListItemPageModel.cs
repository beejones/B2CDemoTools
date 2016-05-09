using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BuyMoreClient
{
    public class PolicyListItemPageModel
    {
        private readonly IPolicyListPage _page;

        public PolicyListItemPageModel(IPolicyListPage page)
        {
            if (page == null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            _page = page;

            RunCommand = new Command(async () =>
            {
                await _page.RunPolicyAsync(Authority, Scope, Policy);
            });
        }

        public string Authority { get; set; }

        public string Caption { get; set; }

        public string Policy { get; set; }

        public ICommand RunCommand { get; }

        public string[] Scope { get; set; }
    }
}
