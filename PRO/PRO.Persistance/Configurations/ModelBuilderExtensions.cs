using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PRO.Persistance.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedImageTypes();
            modelBuilder.SeedImages();
            modelBuilder.SeedApplicationUsers();
            modelBuilder.SeedRoles();
            modelBuilder.SeedUserRoles();
            modelBuilder.SeedAuthors();
            modelBuilder.SeedModerators();

            modelBuilder.SeedStatuses();
            modelBuilder.SeedSeries();
            modelBuilder.SeedTags();
            modelBuilder.SeedListTypes();
            modelBuilder.SeedArticleTypes();
            modelBuilder.SeedGenres();
            modelBuilder.SeedLanguages();
            modelBuilder.SeedCompanies();
            modelBuilder.SeedPlatforms();

            modelBuilder.SeedGames();
            modelBuilder.SeedAwards();
            modelBuilder.SeedGameLanguages();
            modelBuilder.SeedGameTags();
            modelBuilder.SeedUserLists();
            modelBuilder.SeedGameLists();
            modelBuilder.SeedReviews();
            modelBuilder.SeedArticles();

        }
        public static void SeedApplicationUsers(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ApplicationUser>().HasData(
              new ApplicationUser
              {
                  Id = 1,
                  UserName = "Admin",
                  NormalizedUserName = "ADMIN",
                  Email = "a@a.pl",
                  NormalizedEmail = "A@A.PL",
                  PasswordHash = "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==",
                  SecurityStamp = "NLKT3KRF6FZYJAKJBSI5JY5I3GSMNOFT",
                  ConcurrencyStamp = "b780211e-49f4-4497-bc8b-8c2830668bfd",
                  RegisterDate = DateTime.Parse("19.03.2021 23:29:50"),
                  Description = null,
                  IsActive = true,
                  IsPublic = true,
                  ImageId = null,
                  EmailConfirmed = true,
                  LockoutEnabled = true
              },
               new ApplicationUser
               {
                   Id = 2,
                   UserName = "Moderator",
                   NormalizedUserName = "MODERATOR",
                   Email = "moderator@a.pl",
                   NormalizedEmail = "MODERATOR@A.PL",
                   PasswordHash = "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==",
                   SecurityStamp = "7DVGRSDTJBFLREA3JWKP5652YSSE65BW",
                   ConcurrencyStamp = "0e5dabda-21e1-41c3-9ca9-712557e18cb8",
                   RegisterDate = DateTime.Parse("19.03.2021 23:30:37"),
                   Description = null,
                   IsActive = true,
                   IsPublic = true,
                   ImageId = 27,
                   EmailConfirmed = true,
                   LockoutEnabled = true
               },
                new ApplicationUser
                {
                    Id = 3,
                    UserName = "Author",
                    NormalizedUserName = "AUTHOR",
                    Email = "author@a.pl",
                    NormalizedEmail = "AUTHOR@A.PL",
                    PasswordHash = "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==",
                    SecurityStamp = "TVMXT4TOQHJQYEPBI66U4Y6N5R2PN4BS",
                    ConcurrencyStamp = "9aa3cb54-abbf-44df-88ad-442c79613fb5",
                    RegisterDate = DateTime.Parse("19.03.2021 23:30:20"),
                    Description = null,
                    IsActive = true,
                    IsPublic = true,
                    ImageId = 27,
                    EmailConfirmed = true,
                    LockoutEnabled = true
                },
                 new ApplicationUser
                 {
                     Id = 4,
                     UserName = "Stefan",
                     NormalizedUserName = "STEFAN",
                     Email = "c@c.pl",
                     NormalizedEmail = "C@C.PL",
                     PasswordHash = "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==",
                     SecurityStamp = "6GTDRNU4VTDMTYWX7U66A57BT6ACCR3E",
                     ConcurrencyStamp = "397099b8-9228-42bf-b751-6e97fcd9101a",
                     RegisterDate = DateTime.Parse("19.03.2021 23:30:54"),
                     Description = null,
                     IsActive = true,
                     IsPublic = true,
                     ImageId = 27,
                     EmailConfirmed = true,
                     LockoutEnabled = true
                 },
                  new ApplicationUser
                  {
                      Id = 5,
                      UserName = "Andrzej",
                      NormalizedUserName = "ANDRZEJ",
                      Email = "b@b.pl",
                      NormalizedEmail = "B@B.PL",
                      PasswordHash = "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==",
                      SecurityStamp = "XDQ77TTJDPKOJKPRKF6HKYC6Y7P2BCBN",
                      ConcurrencyStamp = "6931d766-59a6-42a4-9c40-3593ea2bdd4a",
                      RegisterDate = DateTime.Parse("19.03.2021 23:43:35"),
                      Description = null,
                      IsActive = true,
                      IsPublic = true,
                      ImageId = 27,
                      EmailConfirmed = true,
                      LockoutEnabled = true
                  }
               );
        }
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IdentityRole<int>>().HasData(
              new IdentityRole<int> { Id = 1, ConcurrencyStamp = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "ADMIN" },
              new IdentityRole<int> { Id = 2, ConcurrencyStamp = Guid.NewGuid().ToString(), Name = "Author", NormalizedName = "AUTHOR" },
              new IdentityRole<int> { Id = 3, ConcurrencyStamp = Guid.NewGuid().ToString(), Name = "Moderator", NormalizedName = "MODERATOR" }
               );
        }
        public static void SeedUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
              new IdentityUserRole<int> { RoleId = 1, UserId = 1 },
              new IdentityUserRole<int> { RoleId = 2, UserId = 1 },
              new IdentityUserRole<int> { RoleId = 3, UserId = 1 },
              new IdentityUserRole<int> { RoleId = 3, UserId = 2 },
              new IdentityUserRole<int> { RoleId = 2, UserId = 3 }
               );
        }
        public static void SeedModerators(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moderator>().HasData(
                new Moderator { UserId = 1, CreatedDate = DateTime.Parse("01.01.1991 17:00:00"), LastLoginDate = null, IsActive = true },
                new Moderator { UserId = 2, CreatedDate = DateTime.Parse("01.01.1991 17:00:00"), LastLoginDate = null, IsActive = true }

               );
        }
        public static void SeedAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { UserId = 1, FirstName = "Jan", LastName = "Kowalski", CreatedDate = DateTime.Parse("01.01.1991 17:00:00"), IsActive = true },
                new Author { UserId = 3, FirstName = "Adam", LastName = "Nowak", CreatedDate = DateTime.Parse("01.01.1991 17:00:00"), IsActive = true }
                );
        }

        public static void SeedStatuses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Zapowiedziana" },
                new Status { Id = 2, Name = "Wczesny dostęp" },
                new Status { Id = 3, Name = "Alfa" },
                new Status { Id = 4, Name = "Beta" },
                new Status { Id = 5, Name = "Dostępna" },
                new Status { Id = 6, Name = "Anulowana" },
                new Status { Id = 7, Name = "Niedostępna" }
               );
        }

        public static void SeedSeries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Series>().HasData(
                new Series { Id = 1, Name = "FIFA" },
                new Series { Id = 2, Name = "Pokemon" },
                new Series { Id = 3, Name = "Mass Effect" },
                new Series { Id = 4, Name = "Assassins Creed" },
                new Series { Id = 5, Name = "Civilization" },
                new Series { Id = 6, Name = "Call of Duty" },
                new Series { Id = 7, Name = "Final Fantasy" }

               );
        }

        public static void SeedTags(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "Pierwszoosobowa" },
                new Tag { Id = 2, Name = "Trzecioosobowa" },
                new Tag { Id = 3, Name = "Fabularna" },
                new Tag { Id = 4, Name = "Otwarty świat" },
                new Tag { Id = 5, Name = "Science-Fiction" },
                new Tag { Id = 6, Name = "Historyczna" },
                new Tag { Id = 7, Name = "Zespołowa" },
                new Tag { Id = 8, Name = "Jeden gracz" },
                new Tag { Id = 9, Name = "Wielu graczy" }

               );
        }
        public static void SeedListTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListType>().HasData(
                new ListType { Id = 1, Name = "Ukończone" },
                new ListType { Id = 2, Name = "Porzucone" },
                new ListType { Id = 3, Name = "Planowane" },
                new ListType { Id = 4, Name = "Obecnie grane" }

               );
        }
        public static void SeedArticleTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleType>().HasData(
                new ArticleType { Id = 1, Name = "Zapowiedź" },
                new ArticleType { Id = 2, Name = "Recenzja" },
                new ArticleType { Id = 3, Name = "Felieton" },
                new ArticleType { Id = 4, Name = "Plotka" },
                new ArticleType { Id = 5, Name = "Aktualizacja" }
               );
        }
        public static void SeedGenres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "RPG" },
                new Genre { Id = 2, Name = "FPS" },
                new Genre { Id = 3, Name = "RTS" },
                new Genre { Id = 4, Name = "Sportowa" },
                new Genre { Id = 5, Name = "Strategiczna" },
                new Genre { Id = 6, Name = "Akcji" }

               );
        }
        public static void SeedLanguages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Name = "Angielski" },
                new Language { Id = 2, Name = "Niemiecki" },
                new Language { Id = 3, Name = "Francuski" },
                new Language { Id = 4, Name = "Japoński" },
                new Language { Id = 5, Name = "Hiszpański" },
                new Language { Id = 6, Name = "Rosyjski" },
                new Language { Id = 7, Name = "Polski" },
                new Language { Id = 8, Name = "Chiński" }
               );
        }
        public static void SeedCompanies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Electronic Arts", CreatedDate = DateTime.Parse("27.05.1982 17:00:00"), IsActive = true },
                new Company { Id = 2, Name = "Bioware", CreatedDate = DateTime.Parse("01.02.1995 17:00:00"), IsActive = true },
                new Company { Id = 3, Name = "Ubisoft", CreatedDate = DateTime.Parse("12.03.1986 17:00:00"), IsActive = true },
                new Company { Id = 4, Name = "Ubisoft Montreal", CreatedDate = DateTime.Parse("26.04.1997 17:00:00"), IsActive = true },
                new Company { Id = 5, Name = "Nintendo", CreatedDate = DateTime.Parse("23.09.1889 17:00:00"), IsActive = true },
                new Company { Id = 6, Name = "Gamefreak", CreatedDate = DateTime.Parse("26.04.1989 17:00:00"), IsActive = true },
                new Company { Id = 7, Name = "Activision", CreatedDate = DateTime.Parse("01.10.1979 17:00:00"), IsActive = true },
                new Company { Id = 8, Name = "Blizzard", CreatedDate = DateTime.Parse("08.02.1991 17:00:00"), IsActive = true },
                new Company { Id = 9, Name = "Treyarch", CreatedDate = DateTime.Parse("01.01.1996 17:00:00"), IsActive = true },
                new Company { Id = 10, Name = "Infinity Ward", CreatedDate = DateTime.Parse("01.05.2002 17:00:00"), IsActive = true },
                new Company { Id = 11, Name = "CD Projekt Red", CreatedDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true },
                new Company { Id = 12, Name = "Firaxis Games", CreatedDate = DateTime.Parse("01.05.1996 17:00:00"), IsActive = true },
                new Company { Id = 13, Name = "Take-Two Interactive", CreatedDate = DateTime.Parse("30.09.1993 17:00:00"), IsActive = true },
                new Company { Id = 14, Name = "Microsoft", CreatedDate = DateTime.Parse("04.04.1975 17:00:00"), IsActive = true },
                new Company { Id = 15, Name = "Sony", CreatedDate = DateTime.Parse("07.05.1946 17:00:00"), IsActive = true },
                new Company { Id = 16, Name = "Square Enix", CreatedDate = DateTime.Parse("07.05.1955 17:00:00"), IsActive = true }

               );
        }
        public static void SeedPlatforms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().HasData(
                new Platform { Id = 1, Name = "Xbox 360", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 14 },
                new Platform { Id = 2, Name = "Xbox One", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 14 },
                new Platform { Id = 3, Name = "Xbox Series X", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 14 },
                new Platform { Id = 4, Name = "Switch", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 5 },
                new Platform { Id = 5, Name = "3DS", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 5 },
                new Platform { Id = 6, Name = "Playstation 3", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 15 },
                new Platform { Id = 7, Name = "Playstation 4", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 15 },
                new Platform { Id = 8, Name = "Playstation 5", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 15 },
                new Platform { Id = 9, Name = "PC ", ReleaseDate = DateTime.Parse("01.01.1994 17:00:00"), IsActive = true, CompanyId = 14 }

               );
        }
        public static void SeedImageTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImageType>().HasData(
                new ImageType { Id = 1, Name = "Gra" },
                new ImageType { Id = 2, Name = "Artykuł" },
                new ImageType { Id = 3, Name = "Użytkownik" }

               );
        }
        public static void SeedImages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                new Image { Id = 1, Name = "FIFA 20", ImagePath = "220px-FIFA_20_Cover213828700.jpg", ImageTypeId = 1 },
                new Image { Id = 2, Name = "FIFA 21", ImagePath = "220px-FIFA_21_Cover214815562.jpg", ImageTypeId = 1 },
                new Image { Id = 3, Name = "Assassins Creed 1", ImagePath = "220px-Assassin's_Creed214827007.jpg", ImageTypeId = 1 },
                new Image { Id = 4, Name = "Little Nightmares II", ImagePath = "6034312b4499a2d8ae681e7ad74b5500-98214840748.jpg", ImageTypeId = 1 },
                new Image { Id = 5, Name = "Cyberpunk 2077", ImagePath = "b05b3823508c28c8f8646e8bcc605b3e-98214849203.jpg", ImageTypeId = 1 },
                new Image { Id = 6, Name = "Pokemon Sword", ImagePath = "Sword_EN_boxart214902510.png", ImageTypeId = 1 },
                new Image { Id = 7, Name = "Assassins Creed 2", ImagePath = "assassinscreed2214915719.jpg", ImageTypeId = 1 },
                new Image { Id = 8, Name = "Assassins Creed Valhalla", ImagePath = "Assassins-creed-valhalla-jaquette214926466.jpg", ImageTypeId = 1 },
                new Image { Id = 9, Name = "Mass Effect", ImagePath = "MassEffect214954176.jpg", ImageTypeId = 1 },
                new Image { Id = 10, Name = "Mass Effect 2", ImagePath = "MassEffect2215000597.png", ImageTypeId = 1 },
                new Image { Id = 11, Name = "Mass Effect 3", ImagePath = "Mass_Effect_3_Game_Cover215010594.jpg", ImageTypeId = 1 },
                new Image { Id = 12, Name = "FFXIV Endwalker", ImagePath = "FFXIV_Endwalker_Amano_art215025516.jpg", ImageTypeId = 1 },
                new Image { Id = 13, Name = "FFXVI", ImagePath = "Final_Fantasy_XVI_Key_Art215032567.png", ImageTypeId = 1 },
                new Image { Id = 14, Name = "Control", ImagePath = "305a13f648147e862ed5e86d83d51dd6-98215049818.jpg", ImageTypeId = 1 },
                new Image { Id = 15, Name = "test", ImagePath = "220px-FIFA_20_Cover214806118.jpg", ImageTypeId = 1 },
                new Image { Id = 16, Name = "Control_article", ImagePath = "control_article214819163.jpg", ImageTypeId = 2 },
                new Image { Id = 17, Name = "valhalla_article", ImagePath = "valhalla_article214830763.jpg", ImageTypeId = 2 },
                new Image { Id = 18, Name = "ffxvi_article", ImagePath = "final-fantasy-xvi-articlejpg214958970.jpg", ImageTypeId = 2 },
                new Image { Id = 19, Name = "fifa21_article", ImagePath = "fifa21_article215010978.png", ImageTypeId = 2 },
                new Image { Id = 20, Name = "pokemonSword-article", ImagePath = "Pokemon-Sword-and-Shield_article215022688.jpg", ImageTypeId = 2 },
                new Image { Id = 21, Name = "assassinscreed2_article", ImagePath = "AssassinsCreed2_article215039580.jpg", ImageTypeId = 2 },
                new Image { Id = 22, Name = "assassinscreed_article", ImagePath = "AssassinsCreed_article215049675.jpg", ImageTypeId = 2 },
                new Image { Id = 23, Name = "masseffect3_article", ImagePath = "masseffect3_article215114959.jpg", ImageTypeId = 2 },
                new Image { Id = 24, Name = "masseffect2_article", ImagePath = "masseffect2_article215122820.jpg", ImageTypeId = 2 },
                new Image { Id = 25, Name = "masseffect_article", ImagePath = "masseffect_article215131862.jpg", ImageTypeId = 2 },
                new Image { Id = 26, Name = "ffxivendwalker_article", ImagePath = "endwalker_article215345214.png", ImageTypeId = 2 },
                new Image { Id = 27, Name = "Parrot", ImagePath = "parrot214853179.jpg", ImageTypeId = 3 }

               );
        }
        public static void SeedGames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Title = "Mass Effect",
                    Description = "Komputerowa fabularna gra akcji stworzona przez studio BioWare, wydana pierwotnie w 2007 roku przez Microsoft Game Studios na konsolę Xbox 360, będąca pierwszą częścią serii Mass Effect.Jej akcja rozgrywa się w XXII wieku, kiedy Drodze Mlecznej grozi zagłada ze strony superzaawansowanej rasy maszyn znanych jako Żniwiarze.Gracz wciela się w komandora Sheparda, elitarnego żołnierza próbującego powstrzymać inwazję.Rozgrywka składa się z kilku głównych elementów: wykonywania zadań, walki, eksplorowania kosmosu i interakcji z bohaterami niezależnymi.",
                    ReleaseDate = DateTime.Parse("01.01.2007 17:00:00"),
                    IsActive = true,
                    PlatformId = 9,
                    StatusId = 5,
                    GenreId = 1,
                    SeriesId = 3,
                    PublisherId = 1,
                    DeveloperId = 2,
                    ImageId = 9
                },
                new Game
                {
                    Id = 2,
                    Title = "Mass Effect 2",
                    Description = "Fabularna gra akcji stworzona przez BioWare, wydana przez Electronic Arts w styczniu 2010 roku na platformy Microsoft Windows i Xbox 360,  a rok później na konsolę PlayStation 3.Stanowi drugą część trylogii Mass Effect.Akcja rozgrywa się w XXII wieku w Drodze Mlecznej, gdzie ludzkości zagraża insektoidalna rasa Obcych znanych jako Zbieracze.Gracz wciela się w postać komandora Sheparda, elitarnego żołnierza sił ziemskich, który w celu pokonania zagrożenia musi skompletować oddział gotowy wziąć udział w misji samobójczej.Wczytując zapis z pierwszej części gracz może kształtować fabułę Mass Effect 2 na wiele sposobów.",
                    ReleaseDate = DateTime.Parse("06.01.2010 17:00:00"),
                    IsActive = true,
                    PlatformId = 9,
                    StatusId = 5,
                    GenreId = 1,
                    SeriesId = 3,
                    PublisherId = 1,
                    DeveloperId = 2,
                    ImageId = 10
                },
                new Game
                {
                    Id = 3,
                    Title = "Mass Effect 3",
                    Description = "Fabularna gra akcji, trzecia część serii Mass Effect, stworzona przez studio BioWare, wydana przez Electronic Arts równocześnie na platformach Microsoft Windows, Xbox 360(z obsługą Kinecta) i PlayStation 3.Ogłoszona została 11 grudnia 2010 roku, a wersja demonstracyjna została udostępniona 14 lutego 2012 roku. Premiera gry nastąpiła 6 marca 2012 roku w Ameryce Północnej i 9 marca 2012 roku w Europie.W Polsce i Australii ukazała się 8 marca 2012 roku, a w Japonii 15 marca 2012 roku. Mass Effect 3 w przeciwieństwie do poprzednich części nie został wydany w pełnej polskiej wersji językowej z dubbingiem, a jedynie z polskimi napisami.",
                    ReleaseDate = DateTime.Parse("06.03.2012 17:00:00"),
                    IsActive = true,
                    PlatformId = 9,
                    StatusId = 5,
                    GenreId = 1,
                    SeriesId = 3,
                    PublisherId = 1,
                    DeveloperId = 2,
                    ImageId = 11
                },
                 new Game
                 {
                     Id = 4,
                     Title = "Assassins Creed",
                     Description = "Przygodowa gra akcji stworzona przez studio Ubisoft Montreal i wydana w listopadzie 2007 roku na konsole PlayStation 3, Xbox 360 oraz w kwietniu 2008 roku na platformę Microsoft Windows.Akcja tytułu toczy się naprzemiennie w dwóch okresach czasowych: podczas III wyprawy krzyżowej, w roku 1191 oraz na początku września 2012 roku.Gracz wciela się w członka bractwa asasynów znanego jako Altaïr ibn La - Ahad, którego celem jest wyeliminowanie dziewięciu postaci propagujących wyprawy krzyżowe i odpowiedzialnych za cierpienia wielu ludzi.Gracz odwiedza pięć historycznych miejsc: Jerozolimę, Damaszek, Akkę, Masjaf oraz Arsuf.",
                     ReleaseDate = DateTime.Parse("06.11.2007 17:00:00"),
                     IsActive = true,
                     PlatformId = 1,
                     StatusId = 5,
                     GenreId = 6,
                     SeriesId = 4,
                     PublisherId = 3,
                     DeveloperId = 4,
                     ImageId = 3
                 },
                  new Game
                  {
                      Id = 5,
                      Title = "Assassins Creed II",
                      Description = "Głównym bohaterem gry jest Ezio Auditore da Firenze, młody szlachcic z bogatej florenckiej rodziny. Podobnie jak Altaïr ibn La-Ahad z pierwszej części gry,jest on praprzodkiem Desmonda Milesa, asasyna przetrzymywanego przez korporację Abstergo Industries. Fabuła rozpoczyna się we współczesności,kiedy Desmond i Lucy Stillman uciekają z Abstergo do kryjówki, gdzie spotykają się z innymi współczesnymi asasynami, Shaunem i Rebeką.W kryjówce Desmond korzysta z ulepszonej wersji animusa i przeżywa wspomnienia swojego przodka, aby przez Efekt Krwi nauczyć się być asasynem.",
                      ReleaseDate = DateTime.Parse("17.11.2009 17:00:00"),
                      IsActive = true,
                      PlatformId = 1,
                      StatusId = 5,
                      GenreId = 6,
                      SeriesId = 4,
                      PublisherId = 3,
                      DeveloperId = 4,
                      ImageId = 7
                  },
                   new Game
                   {
                       Id = 6,
                       Title = "Pokemon Sword",
                       Description = "Pokémon Sword i Pokémon Shield to gry RPG z 2019 roku opracowane przez Game Freak i opublikowane przez The Pokémon Company i Nintendo na Nintendo Switch. Są to pierwsze odsłony ósmej generacji serii gier wideo Pokémon i drugie z serii, po Pokémon: Lets Go, Pikachu!",
                       ReleaseDate = DateTime.Parse("15.11.2019 17:00:00"),
                       IsActive = true,
                       PlatformId = 4,
                       StatusId = 1,
                       GenreId = 1,
                       SeriesId = 2,
                       PublisherId = 5,
                       DeveloperId = 6,
                       ImageId = 6
                   },
                    new Game
                    {
                        Id = 7,
                        Title = "FIFA 20",
                        Description = "FIFA 20 jest komputerową grą sportową o tematyce piłki nożnej. Po raz czwarty w serii FIFA zastosowano silnik gry Frostbite. W grze pojawił się nowy tryb o nazwie „Volta”. Zmiany w mechanizmie rozgrywki zostały zaprezentowane 18 lipca 2019 roku.Wśród zmian względem poprzedniczki, gra posiada przebudowany system stałych fragmentów gry. Najważniejszą zmianą jest dodanie do mechanizmu wykonywania rzutów karnych i rzutów rożnych nowatorskiego systemu celowania i kontroli piłki, która według zapowiedzi twórców została zwiększona.",
                        ReleaseDate = DateTime.Parse("17.11.2019 17:00:00"),
                        IsActive = true,
                        PlatformId = 9,
                        StatusId = 2,
                        GenreId = 4,
                        SeriesId = 1,
                        PublisherId = 1,
                        DeveloperId = 1,
                        ImageId = 1
                    },
                     new Game
                     {
                         Id = 8,
                         Title = "FIFA 21",
                         Description = "FIFA 21 to gra wideo symulująca piłkę nożną wydana przez Electronic Arts w ramach serii FIFA. Jest to 28. odsłona serii FIFA i zostanie wydana 9 października 2021 roku na platformę Microsoft Windows, Nintendo Switch, PlayStation 4 i Xbox One.",
                         ReleaseDate = DateTime.Parse("09.10.2021 17:00:00"),
                         IsActive = true,
                         PlatformId = 7,
                         StatusId = 1,
                         GenreId = 4,
                         SeriesId = 1,
                         PublisherId = 1,
                         DeveloperId = 1,
                         ImageId = 2
                     },
                      new Game
                      {
                          Id = 9,
                          Title = "Cyberpunk 2077",
                          Description = "Komputerowa fabularna gra akcji stworzona przez studio CD Projekt Red.  Stanowi adaptację papierowej gry fabularnej Cyberpunk 2020 i jest osadzona 57 lat później w otwartym świecie dystopijnego Night City.Akcja gry rozgrywa się w świecie przedstawionym z perspektywy pierwszej osoby.Główny bohater Cyberpunka, najemnik o imieniu V, wykonuje zadania, korzystając z umiejętności hakowania i obsługi maszyn, jak również z różnych rodzajów broni.",
                          ReleaseDate = DateTime.Parse("17.11.2022 17:00:00"),
                          IsActive = true,
                          PlatformId = 1,
                          StatusId = 6,
                          GenreId = 6,
                          SeriesId = null,
                          PublisherId = 11,
                          DeveloperId = 11,
                          ImageId = 5
                      },
                       new Game
                       {
                           Id = 10,
                           Title = "Final Fantasy XIV: Endwalker",
                           Description = "Final Fantasy XIV Endwalker trafi do nas jesienią 2021 roku i zakończy wątek fabularny rozwijany od 2013 roku. Jednocześnie będzie to początek zupełnie nowej historii. Od samych twórców dowiedzieliśmy się, że w trakcie przygody trafimy między innymi na księżyc, do stolicy imperium Garlemald oraz do miasta Radz-at - Han.",
                           ReleaseDate = DateTime.Parse("17.11.2021 17:00:00"),
                           IsActive = true,
                           PlatformId = 7,
                           StatusId = 1,
                           GenreId = 1,
                           SeriesId = 7,
                           PublisherId = 16,
                           DeveloperId = 16,
                           ImageId = 12
                       },
                        new Game
                        {
                            Id = 11,
                            Title = "Final Fantasy XVI",
                            Description = "Final Fantasy XVI to nadchodząca gra RPG akcji opracowana i wydana przez Square Enix na PlayStation 5. Jest to szesnasty tytuł z głównej serii Final Fantasy. Grę produkuje Naoki Yoshida, a reżyseruje ją Hiroshi Takai.",
                            ReleaseDate = null,
                            IsActive = true,
                            PlatformId = 7,
                            StatusId = 1,
                            GenreId = 1,
                            SeriesId = 7,
                            PublisherId = 16,
                            DeveloperId = 16,
                            ImageId = 13
                        },
                         new Game
                         {
                             Id = 12,
                             Title = "Assassins Creed Valhalla",
                             Description = "Przygodowa gra akcji wyprodukowana przez kanadyjskie studio Ubisoft Montréal, stanowiąca dwunastą główną odsłonę serii Assassin’s Creed i kontynuację Assassin’s Creed Odyssey. Akcja gry dzieje się w IX wieku w średniowiecznej Anglii.",
                             ReleaseDate = DateTime.Parse("17.12.2021 17:00:00"),
                             IsActive = true,
                             PlatformId = 3,
                             StatusId = 1,
                             GenreId = 6,
                             SeriesId = 4,
                             PublisherId = 3,
                             DeveloperId = 4,
                             ImageId = 8
                         },
                          new Game
                          {
                              Id = 13,
                              Title = "Control",
                              Description = "Control to trzecioosobowa strzelanka science fiction. Gracz musi zmierzyć się z inwazją sił nie z tego świata, a w walce z nimi wykorzystuje szereg zdolności specjalnych oraz telekinetyczny pistolet, który poza strzelaniem pozwala ciskać obiektami i przeciwnikami na odległość.",
                              ReleaseDate = DateTime.Parse("17.10.2021 17:00:00"),
                              IsActive = true,
                              PlatformId = 4,
                              StatusId = 4,
                              GenreId = 5,
                              SeriesId = null,
                              PublisherId = 6,
                              DeveloperId = 7,
                              ImageId = 14
                          },
                           new Game
                           {
                               Id = 14,
                               Title = "Little Nightmares 2",
                               Description = "Little Nightmares II to przygodowa gra logiczno-platformowa z gatunku horroru.",
                               ReleaseDate = null,
                               IsActive = true,
                               PlatformId = 4,
                               StatusId = 1,
                               GenreId = 3,
                               SeriesId = null,
                               PublisherId = 8,
                               DeveloperId = 8,
                               ImageId = 4
                           }

               );
        }

        public static void SeedAwards(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Award>().HasData(
                new Award { Id = 1, Name = "Gra roku 2007", AwardDate = DateTime.Parse("01.01.1991 17:00:00"), GameId = 1 },
                new Award { Id = 2, Name = "Gra roku 2010", AwardDate = DateTime.Parse("01.01.1991 17:00:00"), GameId = 2 },
                new Award { Id = 3, Name = "Gra roku 2012", AwardDate = DateTime.Parse("01.01.1991 17:00:00"), GameId = 3 },
                new Award { Id = 4, Name = "Najlepsza fabuła 2009", AwardDate = DateTime.Parse("01.01.1991 17:00:00"), GameId = 5 },
                new Award { Id = 5, Name = "Najlepsza fabuła 2012", AwardDate = DateTime.Parse("01.01.1991 17:00:00"), GameId = 3 }
               );
        }
        public static void SeedGameLanguages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameLanguage>().HasData(
                new GameLanguage { LanguageId = 1, GameId = 1 },
                new GameLanguage { LanguageId = 2, GameId = 1 },
                new GameLanguage { LanguageId = 3, GameId = 1 },
                new GameLanguage { LanguageId = 1, GameId = 2 },
                new GameLanguage { LanguageId = 2, GameId = 3 },
                new GameLanguage { LanguageId = 4, GameId = 3 },
                new GameLanguage { LanguageId = 6, GameId = 4 },
                new GameLanguage { LanguageId = 7, GameId = 4 },
                new GameLanguage { LanguageId = 8, GameId = 4 },
                new GameLanguage { LanguageId = 1, GameId = 4 },
                new GameLanguage { LanguageId = 1, GameId = 5 },
                new GameLanguage { LanguageId = 3, GameId = 5 },
                new GameLanguage { LanguageId = 7, GameId = 5 },
                new GameLanguage { LanguageId = 1, GameId = 6 },
                new GameLanguage { LanguageId = 2, GameId = 6 },
                new GameLanguage { LanguageId = 1, GameId = 7 },
                new GameLanguage { LanguageId = 1, GameId = 8 },
                new GameLanguage { LanguageId = 2, GameId = 8 },
                new GameLanguage { LanguageId = 1, GameId = 9 },
                new GameLanguage { LanguageId = 2, GameId = 9 },
                new GameLanguage { LanguageId = 4, GameId = 9 },
                new GameLanguage { LanguageId = 1, GameId = 10 },
                new GameLanguage { LanguageId = 2, GameId = 10 },
                new GameLanguage { LanguageId = 3, GameId = 10 },
                new GameLanguage { LanguageId = 4, GameId = 10 },
                new GameLanguage { LanguageId = 6, GameId = 10 },
                new GameLanguage { LanguageId = 1, GameId = 11 },
                new GameLanguage { LanguageId = 3, GameId = 11 },
                new GameLanguage { LanguageId = 5, GameId = 12 },
                new GameLanguage { LanguageId = 7, GameId = 13 },
                new GameLanguage { LanguageId = 8, GameId = 13 },
                new GameLanguage { LanguageId = 2, GameId = 14 },
                new GameLanguage { LanguageId = 3, GameId = 14 },
                new GameLanguage { LanguageId = 4, GameId = 14 },
                new GameLanguage { LanguageId = 5, GameId = 14 },
                new GameLanguage { LanguageId = 6, GameId = 14 },
                new GameLanguage { LanguageId = 7, GameId = 14 }
               );
        }
        public static void SeedGameTags(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameTag>().HasData(
                new GameTag { TagId = 2, GameId = 1 },
                new GameTag { TagId = 3, GameId = 1 },
                new GameTag { TagId = 8, GameId = 1 },
                new GameTag { TagId = 2, GameId = 2 },
                new GameTag { TagId = 3, GameId = 2 },
                new GameTag { TagId = 8, GameId = 2 },
                new GameTag { TagId = 2, GameId = 3 },
                new GameTag { TagId = 3, GameId = 3 },
                new GameTag { TagId = 8, GameId = 3 },
                new GameTag { TagId = 2, GameId = 4 },
                new GameTag { TagId = 4, GameId = 4 },
                new GameTag { TagId = 8, GameId = 4 },
                new GameTag { TagId = 2, GameId = 5 },
                new GameTag { TagId = 4, GameId = 5 },
                new GameTag { TagId = 8, GameId = 5 },
                new GameTag { TagId = 2, GameId = 12 },
                new GameTag { TagId = 4, GameId = 12 },
                new GameTag { TagId = 8, GameId = 12 },
                new GameTag { TagId = 4, GameId = 6 },
                new GameTag { TagId = 9, GameId = 7 },
                new GameTag { TagId = 7, GameId = 7 },
                new GameTag { TagId = 7, GameId = 8 },
                new GameTag { TagId = 9, GameId = 8 },
                new GameTag { TagId = 1, GameId = 9 },
                new GameTag { TagId = 3, GameId = 9 },
                new GameTag { TagId = 4, GameId = 9 },
                new GameTag { TagId = 5, GameId = 9 },
                new GameTag { TagId = 8, GameId = 9 },
                new GameTag { TagId = 3, GameId = 10 },
                new GameTag { TagId = 4, GameId = 10 },
                new GameTag { TagId = 2, GameId = 10 },
                new GameTag { TagId = 9, GameId = 10 },
                new GameTag { TagId = 3, GameId = 11 },
                new GameTag { TagId = 4, GameId = 11 },
                new GameTag { TagId = 2, GameId = 11 },
                new GameTag { TagId = 8, GameId = 11 },
                new GameTag { TagId = 5, GameId = 13 },
                new GameTag { TagId = 8, GameId = 13 },
                new GameTag { TagId = 5, GameId = 14 }

               );
        }
        public static void SeedUserLists(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserList>().HasData(
                new UserList { Id = 1, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Dobre", IsPublic = true, UserId = 1, ListTypeId = 1 },
                new UserList { Id = 2, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Kiepskie", IsPublic = true, UserId = 1, ListTypeId = 2 },
                new UserList { Id = 3, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Kupić", IsPublic = true, UserId = 1, ListTypeId = 3 },
                new UserList { Id = 4, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Gram", IsPublic = true, UserId = 1, ListTypeId = 4 },
                new UserList { Id = 5, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Ukończone", IsPublic = true, UserId = 2, ListTypeId = 1 },
                new UserList { Id = 6, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Porzucone", IsPublic = true, UserId = 2, ListTypeId = 2 },
                new UserList { Id = 7, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Planowane", IsPublic = true, UserId = 2, ListTypeId = 3 },
                new UserList { Id = 8, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Ukończone", IsPublic = true, UserId = 4, ListTypeId = 1 },
                new UserList { Id = 9, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Porzucone", IsPublic = true, UserId = 4, ListTypeId = 2 },
                new UserList { Id = 10, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Ukończone", IsPublic = true, UserId = 5, ListTypeId = 1 },
                new UserList { Id = 11, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Porzucone", IsPublic = true, UserId = 5, ListTypeId = 2 },
                new UserList { Id = 12, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Planowane", IsPublic = true, UserId = 5, ListTypeId = 3 },
                new UserList { Id = 13, CreatedDate = DateTime.Parse("20.02.2012 00:00:00"), Name = "Grane", IsPublic = true, UserId = 5, ListTypeId = 4 }

               );
        }
        public static void SeedGameLists(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameList>().HasData(
                new GameList { Id = 1, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 9, PersonalScore = 8, UserListId = 1, GameId = 1, EditedDate = null },
                new GameList { Id = 2, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 15, PersonalScore = 9, UserListId = 1, GameId = 2, EditedDate = null },
                new GameList { Id = 3, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 26, PersonalScore = 5, UserListId = 2, GameId = 10, EditedDate = null },
                new GameList { Id = 4, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 24, PersonalScore = 4, UserListId = 4, GameId = 8, EditedDate = null },
                new GameList { Id = 5, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 17, PersonalScore = 6, UserListId = 4, GameId = 9, EditedDate = null },
                new GameList { Id = 6, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 12, PersonalScore = 8, UserListId = 5, GameId = 1, EditedDate = null },
                new GameList { Id = 7, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 7, GameId = 1, EditedDate = null },
                new GameList { Id = 8, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 7, GameId = 2, EditedDate = null },
                new GameList { Id = 9, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 7, GameId = 3, EditedDate = null },
                new GameList { Id = 10, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 8, PersonalScore = 1, UserListId = 8, GameId = 7, EditedDate = null },
                new GameList { Id = 11, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 1, PersonalScore = 7, UserListId = 9, GameId = 7, EditedDate = null },
                new GameList { Id = 12, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 3, PersonalScore = 10, UserListId = 9, GameId = 9, EditedDate = null },
                new GameList { Id = 13, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 6, PersonalScore = 10, UserListId = 9, GameId = 8, EditedDate = null },
                new GameList { Id = 14, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 42, PersonalScore = 2, UserListId = 9, GameId = 11, EditedDate = null },
                new GameList { Id = 15, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 15, PersonalScore = 10, UserListId = 9, GameId = 10, EditedDate = null },
                new GameList { Id = 16, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 11, GameId = 11, EditedDate = null },
                new GameList { Id = 17, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 11, GameId = 13, EditedDate = null },
                new GameList { Id = 18, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 11, GameId = 14, EditedDate = null },
                new GameList { Id = 19, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 11, GameId = 10, EditedDate = null },
                new GameList { Id = 20, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 11, GameId = 12, EditedDate = null },
                new GameList { Id = 21, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 0, PersonalScore = null, UserListId = 11, GameId = 3, EditedDate = null },
                new GameList { Id = 22, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 10, PersonalScore = 9, UserListId = 12, GameId = 1, EditedDate = null },
                new GameList { Id = 23, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 20, PersonalScore = 4, UserListId = 12, GameId = 2, EditedDate = null },
                new GameList { Id = 24, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 14, PersonalScore = null, UserListId = 4, GameId = 5, EditedDate = null },
                new GameList { Id = 25, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 52, PersonalScore = 7, UserListId = 8, GameId = 1, EditedDate = null },
                new GameList { Id = 26, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 742, PersonalScore = 9, UserListId = 8, GameId = 2, EditedDate = null },
                new GameList { Id = 27, AddedDate = DateTime.Parse("20.02.2012 00:00:00"), HoursPlayed = 111, PersonalScore = 8, UserListId = 4, GameId = 3, EditedDate = null }

               );
        }
        public static void SeedReviews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, ReviewDate = DateTime.Parse("20.05.2017 00:00:00"), EditDate = null, GraphicsScore = 4, StoryScore = 7, MusicScore = 8, GameplayScore = 7, UserId = 1, GameId = 1, ModeratorId = null, Content = "Gra wciąga, jest ogromna ilość zadań które gracz może wykonać i polecam ją sprawdzić. Jak komuś nie zadziała to szybki zwrot na Steamie i powrót za pół roku po patchach. Osobiście nie myślałem, że gra CDPR mnie tak wciągnie, ale mam już za sobą kilkanaście godzin a zrobiłem może 10% fabuły. Gra jest na wiele godzin, może do końca lockdownu ją przejdę :D" },
                new Review { Id = 2, ReviewDate = DateTime.Parse("20.05.2019 00:00:00"), EditDate = null, GraphicsScore = 6, StoryScore = 7, MusicScore = 6, GameplayScore = 5, UserId = 1, GameId = 2, ModeratorId = null, Content = "Zanim może zacznę piać z zachwytu jaka to nie jest wspaniała gra, to myślę że warto wytłumaczyć dlaczego tak twierdzę. Przede wszystkim Cyberpunk, od momentu zapowiedzi w 2013, ani trochę mnie nie zainteresował. Nie śledziłem żadnych newsów na temat powstawania gry, nie oglądałem materiałów promocyjnych, ani nie oglądałem pierwszych pokazów gameplay. Grę kupiłem spontanicznie około dwa tygodnie przed premierę, nastawiając się na nią bardzo neutralnie, śmiejąc się przy tym z wyolbrzymionych oczekiwań i hype na temat tej gry. Przechodząc jednak do recenzji..." },
                new Review { Id = 3, ReviewDate = DateTime.Parse("10.03.2017 00:00:00"), EditDate = null, GraphicsScore = 7, StoryScore = 7, MusicScore = 7, GameplayScore = 8, UserId = 1, GameId = 3, ModeratorId = null, Content = "Po 18 godzinach i kilku hotfixach muszę przyznać, że gra naprawdę jest coraz mniej zbugowana. Co do fabuły nie można się doczepić - wciąga i wzbudza emocje. Detale w tej grze stoją na najwyższym poziomie, przez co często zamiast skupić się na głównych questach, wolę czasami pochodzić po mieście i porobić coś bardziej oderwanego od ciągu fabuły. Genialna gra, słów brak by opisać wrażenia po tych kilkunastu godzinach gry. Kto się waha - niech się przemoże i kupi tę grę. To najlepiej wydane 200 zł na grę w moim życiu." },
                new Review { Id = 4, ReviewDate = DateTime.Parse("20.09.2012 00:00:00"), EditDate = null, GraphicsScore = 9, StoryScore = 9, MusicScore = 5, GameplayScore = 8, UserId = 1, GameId = 5, ModeratorId = null, Content = "Najprawdopodobniej jedna z najlepszych gier jakie powstały. Idealnie pokazuje brudny cyberpunkowy świat przez co wczucie się w cały ten klimat przychodzi z łatwością. Gra ma swoje problemy (liczne bugi, niektóre bardziej upierdliwe, drugie mniej) ale fabularnie - jest miazga. Mimo wszystko, warto poczekać na łatki które naprawią zdecydowaną większość bugów, ale nie zmienia to faktu że dostaliśmy coś, na co warto było czekać." },
                new Review { Id = 5, ReviewDate = DateTime.Parse("20.05.2012 00:00:00"), EditDate = null, GraphicsScore = 10, StoryScore = 10, MusicScore = 9, GameplayScore = 9, UserId = 1, GameId = 9, ModeratorId = null, Content = "Myślę że po 85 godzinach spędzonych w Night City, mogę wreszcie opisać jak czuję się z nowym tworem CD Projekt Red zwanym Cyberpunk 2077 bazowanym na papierowej grze fabularnej Cyberpunk 2020 stworzonej przez Mikea Pondsmitha. Po ośmiu latach w końcu doczekaliśmy się premiery gry na którą czekała bardzo dużą część graczy." },
                new Review { Id = 6, ReviewDate = DateTime.Parse("20.05.2012 00:00:00"), EditDate = null, GraphicsScore = 7, StoryScore = 5, MusicScore = 4, GameplayScore = 5, UserId = 4, GameId = 1, ModeratorId = null, Content = "Na początku myślałem ,że to żart jak gra jest zabugowana no i jak działa ale... no i właśnie jest to ale po przestawieniu myślenia i wgłębieniu się w fabułę ciężko było mi oderwać się od fabuły zarówno głównej jak i pobocznej. Jedna z lepiej napisanych historii. Czy gra mogłaby być lepiej zoptymalizowana - jasne, czy powinno być mnie bugów i glitch - jasne." },
                new Review { Id = 7, ReviewDate = DateTime.Parse("25.05.2015 00:00:00"), EditDate = DateTime.Parse("21.02.2015 00:00:00"), GraphicsScore = 6, StoryScore = 6, MusicScore = 3, GameplayScore = 2, UserId = 4, GameId = 2, ModeratorId = 1, Content = "Cyberpunk 2077. Jeżeli o mnie chodzi nie czułem jakiegoś mocnego hajpu na tę grę, nie czekałem na nią jakoś mocno, nawet nie planowałem jej kupić, a tym bardziej na premierę, bo nie jestem zwolennikiem kupowania gier zaraz po ich wyjściu, nie zapoznając się wcześniej z opiniami i recenzjami danej gry, jedyne co przyciągało moją uwagę to mocna kampania marketingowa i to że jest to gra polskiego studia CD projekt" },
                new Review { Id = 8, ReviewDate = DateTime.Parse("01.06.2012 00:00:00"), EditDate = DateTime.Parse("21.06.2012 00:00:00"), GraphicsScore = 1, StoryScore = 2, MusicScore = 1, GameplayScore = 2, UserId = 4, GameId = 3, ModeratorId = 1, Content = "Gra stawia nowe filary w gamedevie, jeśli chodzi o wertykalną warstwę fabularną, czy też oprawę audiowizualną. Ogrywanie jej na RayTracingu to istne wzrokowe wodotryski, ale nie każdy portfel jest na tyle gruby, żeby ograć to w stabilnych 60 klatkach. Natomiast gra ma potężne wady, których nie jestem w stanie wybaczyć developerom." },
                new Review { Id = 9, ReviewDate = DateTime.Parse("20.12.2018 00:00:00"), EditDate = null, GraphicsScore = 6, StoryScore = 8, MusicScore = 7, GameplayScore = 7, UserId = 4, GameId = 11, ModeratorId = null, Content = "Sądzę, że po przegraniu 160h+ mogę w końcu się wypowiedzieć. Gra ma błędy. Ale nie są to błędy niszczące rozrywkę, w najgorszym przypadku wystarczy wgrać save i po sprawie. tym bardziej, że sejwy wgrywają się w parenaście-paredziesiąt sekund. Pod względem otwartego świata nie to parę rzeczy kuleje" },
                new Review { Id = 10, ReviewDate = DateTime.Parse("20.11.2012 00:00:00"), EditDate = null, GraphicsScore = 9, StoryScore = 7, MusicScore = 9, GameplayScore = 7, UserId = 4, GameId = 12, ModeratorId = null, Content = "Zdecydowanie polecam ale nie będę kłamać że gra na obecną chwile jest idealna, zarzuty w kwestii większych lub mniejszych błędów są jak najbardziej prawdziwe, ale to wciąż dobrze wykreowany i zbudowany świat z dobrą historią i świetnymi postaciami. Moja ocena 7/10. Przyszłe patche naprawią grę i będzie 10/10 :)" },
                new Review { Id = 11, ReviewDate = DateTime.Parse("20.10.2019 00:00:00"), EditDate = DateTime.Parse("21.02.2020 00:00:00"), GraphicsScore = 5, StoryScore = 5, MusicScore = 4, GameplayScore = 7, UserId = 5, GameId = 1, ModeratorId = 2, Content = "Dla tych co się zastanawiają nad kupnem gry na szybko..., jeśli nie przeszkadzają Ci wizualne błędy, a Twój komputer daje przysłowiowo radę, to bierz i nie zastanawiaj się. Ja osobiście w trakcie 50h gry nie uświadczyłem żadnego crasha, poważnych błędów lub zbugowanych questów. A nawet jeśli by się zdarzyło to dla mnie żaden problem dopóki nie jest to częste." },
                new Review { Id = 12, ReviewDate = DateTime.Parse("20.02.2020 00:00:00"), EditDate = null, GraphicsScore = 7, StoryScore = 2, MusicScore = 3, GameplayScore = 5, UserId = 5, GameId = 2, ModeratorId = null, Content = "Są drobne bugi w grze, najczęściej zdarzało mi się, że nie mogłem podnosić różnych itemów. Postacie jak i auta kawałek się teleportują. Animacje postaci ludzią przeskakiwać tzn. jedna po drugiej nie są płynne." },
                new Review { Id = 13, ReviewDate = DateTime.Parse("20.02.2014 00:00:00"), EditDate = DateTime.Parse("21.02.2015 00:00:00"), GraphicsScore = 5, StoryScore = 7, MusicScore = 6, GameplayScore = 4, UserId = 5, GameId = 5, ModeratorId = 2, Content = "Obcowanie z tą grą to sinusoida oceny. Od początkowego zachwytu (grafiką i klimatem), przez rozczarowanie (odkrywanie elementów, które są strasznie słabe), realizm (wady nie przesłaniają zalet), aż po zakochanie (zżycie z postaciami i siła emocji przesłaniają biedę innych elementów)" },
                new Review { Id = 14, ReviewDate = DateTime.Parse("20.02.2018 00:00:00"), EditDate = null, GraphicsScore = 8, StoryScore = 7, MusicScore = 8, GameplayScore = 8, UserId = 5, GameId = 7, ModeratorId = null, Content = "Zdecydowanie się nie zawiodłem, klimaty i oprawa gry jest dokładnie taka jak sobie wyobrażałem. Rozgrywka bardzo przyjemna zdecydowanie nie będziecie się nudzić na mapie jest mnóstwo aktywności. Mapa jest świetnie zrobiona Night City wygląda ja faktyczna cyberpunkowa metropolia. Niestety na tą chwilę ma duże problemy z optymalizacją i jest sporo błędów ale wierzę że za jakiś czas twórcy to naprawią. Gra zdecydowanie warta polecenia." },
                new Review { Id = 15, ReviewDate = DateTime.Parse("20.03.2016 00:00:00"), EditDate = null, GraphicsScore = 5, StoryScore = 7, MusicScore = 6, GameplayScore = 10, UserId = 1, GameId = 11, ModeratorId = null, Content = "Mimo kilku małych problemów nie przeszkodziło mi to z cieszenia się z gry. Przez 6 godzin grania musiałem wczytać checkpoint tylko raz przez jednego buga. Nowe patche mogą pomóc z optymalizacją więc polecam na nie czekać ( Patch 1.04 właśnie wiele problemów z optymalizacją naprawił )" },
                new Review { Id = 16, ReviewDate = DateTime.Parse("12.02.2015 00:00:00"), EditDate = null, GraphicsScore = 7, StoryScore = 6, MusicScore = 9, GameplayScore = 8, UserId = 2, GameId = 1, ModeratorId = null, Content = "Uwaga uwaga, gra ma bugi, kto by się spodziewał. Dobra to teraz o grze. Jest spoko, krótka, ale sporo zadań pobocznych. customizacja jest dość słaba, ale dobieranie zdolności i ogólnie aspekty RPG typu drzewka, statystyki broni itp są bardzo mocne. Grafika jest dobra, nawet na średnio niskich ustawieniach. Na pierwszym patchu w czasie jednej z misji pod koniec drugiego aktu gra się wysypywała, ale teraz nie ma większych problemów. Fabuła jest okej" }


               );
        }
        public static void SeedArticles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article { Id = 1, GameId = 1, UserId = 1, ArticleTypeId = 1, ImageId = 25, IsActive = true, PublishedDate = DateTime.Parse("15.04.2019 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 2, GameId = 2, UserId = 1, ArticleTypeId = 1, ImageId = 24, IsActive = true, PublishedDate = DateTime.Parse("22.08.2019 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 3, GameId = 3, UserId = 1, ArticleTypeId = 1, ImageId = 23, IsActive = true, PublishedDate = DateTime.Parse("20.09.2010 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 4, GameId = 4, UserId = 1, ArticleTypeId = 1, ImageId = 22, IsActive = true, PublishedDate = DateTime.Parse("27.04.2012 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 5, GameId = 5, UserId = 1, ArticleTypeId = 1, ImageId = 21, IsActive = true, PublishedDate = DateTime.Parse("01.02.2016 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 6, GameId = 6, UserId = 1, ArticleTypeId = 2, ImageId = 20, IsActive = true, PublishedDate = DateTime.Parse("09.04.2017 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 7, GameId = 8, UserId = 3, ArticleTypeId = 2, ImageId = 19, IsActive = true, PublishedDate = DateTime.Parse("21.07.2016 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 8, GameId = 10, UserId = 3, ArticleTypeId = 2, ImageId = 26, IsActive = true, PublishedDate = DateTime.Parse("10.10.2017 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 9, GameId = 11, UserId = 3, ArticleTypeId = 2, ImageId = 18, IsActive = true, PublishedDate = DateTime.Parse("25.11.2018 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 10, GameId = 12, UserId = 3, ArticleTypeId = 3, ImageId = 17, IsActive = true, PublishedDate = DateTime.Parse("15.12.2019 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
                new Article { Id = 11, GameId = 13, UserId = 3, ArticleTypeId = 3, ImageId = 16, IsActive = true, PublishedDate = DateTime.Parse("11.12.2019 00:00:00"), SourceLink = "link", Title = "Tytuł artykułu", Preview = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." }


               );
        }

    }
}
