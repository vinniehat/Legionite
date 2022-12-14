using System.ComponentModel.DataAnnotations;

namespace Legionite.Web.Areas.Identity.Models.AccountViewModels;

public class LoginWithRecoveryCodeViewModel
{
    [Required]
    [DataType(DataType.Text)]
    [Display(Name = "Recovery Code")]
    public string RecoveryCode { get; set; }
}