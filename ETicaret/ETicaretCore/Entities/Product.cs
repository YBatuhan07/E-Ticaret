using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities
{
    public class Product : IEntity
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Ürün")]
        public string Name { get; set; } = default!;
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; } // Resim dosyalarını nullable olarak tanımla. Sorun çıkartabilir
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Display(Name = "Ürün kodu")]
        public string? ProductCode { get; set; }
        [Display(Name = "Stok durumu")]
        public int Stock { get; set; }
        [Display(Name = "Aktif mi")]
        public bool IsActive { get; set; }
        [Display(Name = "Anasayfa")]
        public bool IsHome { get; set; }
        [Display(Name = "Kategori ID")]
        public int? CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public Category? Category { get; set; }
        [Display(Name = "Marka ID")]
        public int? BrandId { get; set; }
        [Display(Name = "Marka")]
        public Brand? Brand { get; set; }
        [Display(Name = "Ürün no")]
        public int OrderNo { get; set; } // Sıralamak için kullanılır. Örneğin 1 de telefonlar görünsün. 2 de Tabletler gibi. Filtrelemelerde kullanılacak
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
