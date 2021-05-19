using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRO.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Toolbelt.ComponentModel.DataAnnotations;

namespace PRO.Persistance.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<ListType> ListTypes { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<GameList> GameLists { get; set; }
        public DbSet<ImageType> ImageTypes { get; set; }
        public DbSet<GameLanguage> GameLanguage { get; set; }
        public DbSet<GameTag> GameTag { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //TODO setup of in-memory database just for testing purposes
            // optionsBuilder.UseInMemoryDatabase("SampleDatabase");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.BuildIndexesFromAnnotations();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.Seed();

            modelBuilder.Entity<Game>().HasMany(x => x.Tags)
                .WithMany(x => x.Games)
                .UsingEntity<GameTag>(
                    x => x.HasOne(x => x.Tag)
                    .WithMany().HasForeignKey(x => x.TagId),
                    x => x.HasOne(x => x.Game)
                   .WithMany().HasForeignKey(x => x.GameId));

            modelBuilder.Entity<Game>().HasMany(x => x.Languages)
                .WithMany(x => x.Games)
                .UsingEntity<GameLanguage>(
                    x => x.HasOne(x => x.Language)
                    .WithMany().HasForeignKey(x => x.LanguageId),
                    x => x.HasOne(x => x.Game)
                   .WithMany().HasForeignKey(x => x.GameId));
        }
        public override int SaveChanges()
        {
            var changedEntities = ChangeTracker
                .Entries()
                .Where(_ => _.State == EntityState.Added ||
                            _.State == EntityState.Modified);

            var errors = new List<ValidationResult>(); // all errors are here
            foreach (var e in changedEntities)
            {
                var vc = new ValidationContext(e.Entity, null, null);
                Validator.TryValidateObject(
                    e.Entity, vc, errors, validateAllProperties: true);
            }

            return base.SaveChanges();
        }
    }


}
