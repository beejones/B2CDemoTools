namespace BuyMoreClient
{
    public class PolicyInfo
    {
        public PolicyInfo(
            string authority,
            string caption,
            string policy,
            string[] scope)
        {
            Authority = authority;
            Caption = caption;
            Policy = policy;
            Scope = scope;
        }

        public string Authority { get; }

        public string Caption { get; }

        public string Policy { get; }

        public string[] Scope { get; }
    }
}
