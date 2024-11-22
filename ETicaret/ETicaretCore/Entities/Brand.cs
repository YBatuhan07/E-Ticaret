using System.ComponentModel;

namespace ETicaretCore.Entities;

public class Brand : IEntity
{
    [DisplayName("Id")]
    public int Id { get; set; }
    [DisplayName("Ürün Adı")]
    public string Name { get; set; } = default!;
    [DisplayName("Açıklama")]
    public string? Description { get; set; }
    [DisplayName("Logo")]
    public string? Logo { get; set; } // Resim dosyalarını nullable olarak tanımla. Sorun çıkartabilir
    [DisplayName("Aktif mi?")]
    public bool IsActive { get; set; }
    [DisplayName("Marka no")]
    public int OrderNo { get; set; }
    [DisplayName("Markalar")]
    public IList<Product>? Products { get; set; } // IList kullanıldı
    [DisplayName("Eklenme Tarihi")]
    public DateTime CreateDate { get; set; } = DateTime.Now;


}
