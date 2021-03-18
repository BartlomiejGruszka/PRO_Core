using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO.Entities;

namespace PRO.Persistance.Configurations
{
    class GameTagConfiguration : IEntityTypeConfiguration<GameTag>
    {


        public void Configure(EntityTypeBuilder<GameTag> builder)
        {
            builder
         .HasKey(bc => new { bc.GameId, bc.TagId });
            builder
                .HasOne(bc => bc.Game)
                .WithMany(b => b.GameTags)
                .HasForeignKey(bc => bc.GameId);
            builder
                .HasOne(bc => bc.Tag)
                .WithMany(c => c.GameTags)
                .HasForeignKey(bc => bc.TagId);
        }
    }
}
