using System.ComponentModel.DataAnnotations;

namespace Bit.Core.Models.Data.Organizations.Policies
{
    public class MasterPasswordDataRequirementsModel : IPolicyDataModel
    {
        public int MinComplexity { get; set; }
        public int MinLength { get; set; }
        [Display(Name = "requireUpper")]
        public bool RequireUppercase { get; set; }
        [Display(Name = "requireLower")]
        public bool RequireLowercase { get; set; }
        [Display(Name = "requireNumber")]
        public bool RequireNumber { get; set; }
        [Display(Name = "requireSpecial")]
        public bool RequireSpecial { get; set; }
    }
}
