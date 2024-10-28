namespace ETicaretCore.Entities;

public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; } // Resim dosyalarını nullable olarak tanımla. Sorun çıkartabilir
    public bool IsActive { get; set; }
    public bool IsTopMenu { get; set; }
    public int ParentId { get; set; }
    public int OrderNo { get; set; } // Sıralamak için kullanılır. Örneğin 1 de telefonlar görünsün. 2 de Tabletler gibi. Filtrelemelerde kullanılacak
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public IList<Product>? Products { get; set; } // IList kullanıldı
}
