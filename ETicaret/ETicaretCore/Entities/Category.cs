using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities;

public class Category : IEntity
{
    public int Id { get; set; }
    [Display(Name = "Kategori")]
    public string Name { get; set; } = default!;
    [Display(Name = "Açıklama")]
    public string? Description { get; set; }
    [Display(Name = "Görsel")]
    public string? Image { get; set; } // Resim dosyalarını nullable olarak tanımla. Sorun çıkartabilir
    [Display(Name = "Aktif mi?")]
    public bool IsActive { get; set; }
    [Display(Name = "Üst menüde gösterilsin mi?")]
    public bool IsTopMenu { get; set; }
    [Display(Name = "Üst kategori")]
    public int ParentId { get; set; }
    [Display(Name = "Sıra no")]
    public int OrderNo { get; set; } // Sıralamak için kullanılır. Örneğin 1 de telefonlar görünsün. 2 de Tabletler gibi. Filtrelemelerde kullanılacak
    [Display(Name = "Eklenme Tarihi")]
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public IList<Product>? Products { get; set; } // IList kullanıldı
}
