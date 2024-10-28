using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaretData.Configurations;

public class SliderConfiguration : IEntityTypeConfiguration<Slider>
{
    public void Configure(EntityTypeBuilder<Slider> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(500);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.Image).HasMaxLength(500);
        builder.Property(x => x.Link).HasMaxLength(500);
    }
}
