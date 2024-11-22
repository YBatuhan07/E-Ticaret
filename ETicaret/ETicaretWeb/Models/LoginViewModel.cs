using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ETicaretWeb.Models;

public class LoginViewModel
{
    [DisplayName("E-mail")]
    [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = default!;
    [DisplayName("Şifre")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage ="Şifre alanı boş bırakılamaz.")]
    public string Password { get; set; } = default!;
    public string? ReturnUrl { get; set; }
    public bool RememberMe { get; set; }

}
