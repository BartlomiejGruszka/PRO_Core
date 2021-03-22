using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRO.Entities;
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
            // modelBuilder.Seed();
        }
        protected override DbEntityValidationResult ValidateEntity
            (DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            // create our customized result to add a possible DbValidationError to it
            var result = new DbEntityValidationResult(entityEntry, new List<DbValidationError>());

            // We need to check for duplication just in case of adding new entities or modifing existed ones
            if (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified)
                checkDuplication(entityEntry, result);

            // After we did our check to the entity, if we found any duplication, we don't want to continue
            // so we just return our DbEntityValidationResult
            if (!result.IsValid)
                return result;

            // If we didn't find and duplications, then let DbContext do its ordinary checks
            return base.ValidateEntity(entityEntry, items);
        }
    }


}
