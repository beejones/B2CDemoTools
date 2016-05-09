using System.Threading.Tasks;

namespace BuyMoreClient
{
    public interface IPolicyListPage
    {
        Task RunPolicyAsync(
            string authority,
            string[] scope,
            string policy);
    }
}
