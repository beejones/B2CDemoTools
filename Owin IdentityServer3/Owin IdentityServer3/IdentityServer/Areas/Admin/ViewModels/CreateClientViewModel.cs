using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Areas.Admin.ViewModels
{
    public class CreateClientViewModel
    {
        [Display(Name = "Tenant name")]
        [RegularExpression("[0-9A-Za-z]*.onmicrosoft.com")]
        [Required]
        public string TenantName { get; set; }
    }
}
