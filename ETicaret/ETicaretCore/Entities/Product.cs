﻿namespace ETicaretCore.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; } // Resim dosyalarını nullable olarak tanımla. Sorun çıkartabilir
        public decimal Price { get; set; }
        public string? ProductCode { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int OrderNo { get; set; } // Sıralamak için kullanılır. Örneğin 1 de telefonlar görünsün. 2 de Tabletler gibi. Filtrelemelerde kullanılacak
        public DateTime CreateDate { get; set; }
    }
}
