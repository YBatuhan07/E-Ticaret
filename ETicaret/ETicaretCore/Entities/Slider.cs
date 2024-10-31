using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities
{
    public class Slider : IEntity
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        public string? Title { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Link")]
        public string? Link { get; set; }
    }
}
