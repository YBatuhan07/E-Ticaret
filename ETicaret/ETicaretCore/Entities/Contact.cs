using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities;

public class Contact : IEntity
{
    public int Id { get; set; }
    [DisplayName("İsim"),Required(ErrorMessage ="{0} Alanı boş geçilemez")]
    public string Name { get; set; } = default!;
    [DisplayName("Soyisim"), Required(ErrorMessage = "{0} Alanı boş geçilemez")]
    public string Surname { get; set; } = default!;
    [DisplayName("Telefon")]
    public string? Phone { get; set; }
    [DisplayName("Email")]
    public string? Email { get; set; }
    [DisplayName("Mesaj"), Required(ErrorMessage = "{0} Alanı boş geçilemez")]
    public string Message { get; set; } = default!;
    [DisplayName("Eklenme Tarihi")]
    public DateTime CreateDate { get; set; } = DateTime.Now;

}
