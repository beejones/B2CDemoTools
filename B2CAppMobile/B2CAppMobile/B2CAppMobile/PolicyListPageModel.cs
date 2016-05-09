using System.Collections.Generic;
using System.Linq;

namespace BuyMoreClient
{
    public class PolicyListPageModel
    {
        public PolicyListPageModel(IPolicyListPage page)
        {
            InitializePolicyListItems(page);
        }

        public IEnumerable<PolicyListItemPageModel> PolicyListItems { get; set; }

        private void InitializePolicyListItems(IPolicyListPage page)
        {
            PolicyListItems = App.Policies.Select(policy => new PolicyListItemPageModel(page)
            {
                Authority = policy.Authority,
                Caption = policy.Caption,
                Policy = policy.Policy,
                Scope = policy.Scope
            }).ToArray();
        }
    }
}
