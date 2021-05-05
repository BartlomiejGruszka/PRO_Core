using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Services;
using PRO.Entities;
using PRO.Persistance.Data;
using PRO.Persistance.Repositories;
using System;

namespace PRO
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole<int>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();

            services.AddScoped(typeof(IRepository<Game>), typeof(GameRepository));
            services.AddScoped(typeof(IRepository<Image>), typeof(ImageRepository));
            services.AddScoped(typeof(IRepository<ImageType>), typeof(BaseRepository<ImageType>));
            services.AddScoped(typeof(IRepository<ApplicationUser>), typeof(BaseRepository<ApplicationUser>));
            services.AddScoped(typeof(IRepository<Article>), typeof(BaseRepository<Article>));
            services.AddScoped(typeof(IRepository<GameList>), typeof(GameListRepository));
            services.AddScoped(typeof(IRepository<Review>), typeof(BaseRepository<Review>));
            services.AddScoped(typeof(IRepository<ArticleType>), typeof(BaseRepository<ArticleType>));
            services.AddScoped(typeof(IRepository<Author>), typeof(BaseRepository<Author>));
            services.AddScoped(typeof(IRepository<Language>), typeof(BaseRepository<Language>));
            services.AddScoped(typeof(IRepository<Tag>), typeof(BaseRepository<Tag>));
            services.AddScoped(typeof(IRepository<Genre>), typeof(BaseRepository<Genre>));
            services.AddScoped(typeof(IRepository<Platform>), typeof(BaseRepository<Platform>));
            services.AddScoped(typeof(IRepository<Company>), typeof(BaseRepository<Company>));
            services.AddScoped(typeof(IRepository<UserList>), typeof(BaseRepository<UserList>));
            services.AddScoped(typeof(IRepository<Series>), typeof(BaseRepository<Series>));
            services.AddScoped(typeof(IRepository<Status>), typeof(BaseRepository<Status>));
            services.AddScoped(typeof(IRepository<ListType>), typeof(BaseRepository<ListType>));
            services.AddScoped(typeof(IRepository<Moderator>), typeof(BaseRepository<Moderator>));
            services.AddScoped(typeof(IRepository<Award>), typeof(BaseRepository<Award>));

            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IGameListRepository, GameListRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IPlatformRepository, PlatformRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserListRepository, UserListRepository>();
            services.AddScoped<IModeratorRepository, ModeratorRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            //  services.AddScoped<IRepository<ImageType>, ImageTypeRepository>();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IArticleTypeService, ArticleTypeService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IAwardService, AwardService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IGameListService, GameListService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IImageTypeService, ImageTypeService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IListTypeService, ListTypeService>();
            services.AddScoped<IModeratorService, ModeratorService>();
            services.AddScoped<IPlatformService, PlatformService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ISeriesService, SeriesService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IUserListService, UserListService>();
            services.AddScoped<IUserService, UserService>();
                 
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //identity services
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });

            //access to identityuser from outside classes
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               // app.UseDatabaseErrorPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
