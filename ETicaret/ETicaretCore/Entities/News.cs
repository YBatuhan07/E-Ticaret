using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities
{
    public class News : IEntity
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Kampanya ve Duyurular")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Aktif mi")]
        public bool IsActive { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
