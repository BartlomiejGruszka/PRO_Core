using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRO.Entities;

namespace PRO.Persistance.Configurations
{
    class GameLanguageConfiguration : IEntityTypeConfiguration<GameLanguage>
    {


        public void Configure(EntityTypeBuilder<GameLanguage> builder)
        {
            builder
         .HasKey(bc => new { bc.GameId, bc.LanguageId });
            builder
                .HasOne(bc => bc.Game)
                .WithMany(b => b.GameLanguages)
                .HasForeignKey(bc => bc.GameId);
            builder
                .HasOne(bc => bc.Language)
                .WithMany(c => c.GameLanguages)
                .HasForeignKey(bc => bc.LanguageId);
        }
    }
}
