﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities;

public class AppUser : IEntity
{
    [DisplayName("Kullanıcı Id")]
    public int Id { get; set; }
    [DisplayName("İsim")]
    public string Name { get; set; } = default!;
    [DisplayName("Soyisim")]
    public string Surname { get; set; } = default!;
    [DisplayName("E-mail")]
    public string Email { get; set; } = default!;
    [DisplayName("Şifre")]
    public string Password { get; set; } = default!;
    [DisplayName("Kullanıcı Adı")]
    public string UserName { get; set; } = default!;
    [DisplayName("Telefon")]
    public string? Phone { get; set; }
    [DisplayName("Aktif mi?")]
    public bool IsActive { get; set; }
    [DisplayName("Admin mi?")]
    public bool IsAdmin { get; set; }
    [DisplayName("Satıcı mi?")]
    public bool IsCustomer { get; set; }
    [DisplayName("Eklenme tarihi")]
    public DateTime CreateDate { get; set; } = DateTime.Now;
    [DisplayName("User Guid")]
    public Guid? UserGuid { get; set; } = Guid.NewGuid();

   
}
