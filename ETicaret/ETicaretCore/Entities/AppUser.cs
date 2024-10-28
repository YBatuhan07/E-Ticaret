using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities;

public class AppUser : IEntity
{
    [DisplayName("Kullanıcı Id")]
    public int Id { get; set; }
    [DisplayName("İsim")]
    public string Name { get; set; }
    [DisplayName("Soyisim")]
    public string Surname { get; set; }
    [DisplayName("E-mail")]
    public string Email { get; set; }
    [DisplayName("Şifre")]
    public string Password { get; set; }
    [DisplayName("Kullanıcı Adı")]
    public string? UserName { get; set; }
    [DisplayName("Telefon")]
    public string? Phone { get; set; }
    [DisplayName("Aktif mi?")]
    public bool IsActive { get; set; }
    [DisplayName("Admin mi?")]
    public bool IsAdmin { get; set; }
    [DisplayName("Eklenme tarihi")]
    public DateTime CreateDate { get; set; } = DateTime.Now;
    [DisplayName("User Guid")]
    public Guid? UserGuid { get; set; } = Guid.NewGuid();

   
}
