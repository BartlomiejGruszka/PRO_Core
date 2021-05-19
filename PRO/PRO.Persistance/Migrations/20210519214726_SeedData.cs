using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PRO.Persistance.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArticleTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Zapowiedź" },
                    { 2, "Recenzja" },
                    { 3, "Felieton" },
                    { 4, "Plotka" },
                    { 5, "Aktualizacja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "5a4d59bf-9d5a-480a-8afd-dbcbb861f722", "Admin", "ADMIN" },
                    { 2, "9316336e-1ae0-43ee-ad93-8abf4b47b02d", "Author", "AUTHOR" },
                    { 3, "f4c0db18-8d29-46dc-99ad-5a78424b8386", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "ImageId", "IsActive", "IsPublic", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisterDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "b780211e-49f4-4497-bc8b-8c2830668bfd", null, "a@a.pl", true, null, true, true, true, null, "A@A.PL", "ADMIN", "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==", null, false, new DateTime(2021, 3, 19, 23, 29, 50, 0, DateTimeKind.Unspecified), "NLKT3KRF6FZYJAKJBSI5JY5I3GSMNOFT", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name" },
                values: new object[,]
                {
                    { 16, new DateTime(1955, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Square Enix" },
                    { 15, new DateTime(1946, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Sony" },
                    { 14, new DateTime(1975, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Microsoft" },
                    { 13, new DateTime(1993, 9, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Take-Two Interactive" },
                    { 12, new DateTime(1996, 5, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Firaxis Games" },
                    { 11, new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "CD Projekt Red" },
                    { 9, new DateTime(1996, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Treyarch" },
                    { 10, new DateTime(2002, 5, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Infinity Ward" },
                    { 7, new DateTime(1979, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Activision" },
                    { 6, new DateTime(1989, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Gamefreak" },
                    { 5, new DateTime(1889, 9, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Nintendo" },
                    { 4, new DateTime(1997, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Ubisoft Montreal" },
                    { 3, new DateTime(1986, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Ubisoft" },
                    { 2, new DateTime(1995, 2, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Bioware" },
                    { 1, new DateTime(1982, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Electronic Arts" },
                    { 8, new DateTime(1991, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Blizzard" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Akcji" },
                    { 5, "Strategiczna" },
                    { 4, "Sportowa" },
                    { 3, "RTS" },
                    { 1, "RPG" },
                    { 2, "FPS" }
                });

            migrationBuilder.InsertData(
                table: "ImageTypes",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Gra", 1 },
                    { 2, "Artykuł", 0 },
                    { 3, "Użytkownik", 2 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Rosyjski" },
                    { 8, "Chiński" },
                    { 7, "Polski" },
                    { 5, "Hiszpański" },
                    { 1, "Angielski" },
                    { 3, "Francuski" },
                    { 2, "Niemiecki" },
                    { 4, "Japoński" }
                });

            migrationBuilder.InsertData(
                table: "ListTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukończone" },
                    { 2, "Porzucone" },
                    { 3, "Planowane" },
                    { 4, "Obecnie grane" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Final Fantasy" },
                    { 6, "Call of Duty" },
                    { 5, "Civilization" },
                    { 2, "Pokemon" },
                    { 3, "Mass Effect" },
                    { 1, "FIFA" },
                    { 4, "Assassins Creed" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Anulowana" },
                    { 7, "Niedostępna" },
                    { 5, "Dostępna" },
                    { 1, "Zapowiedziana" },
                    { 3, "Alfa" },
                    { 2, "Wczesny dostęp" },
                    { 4, "Beta" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Jeden gracz" },
                    { 1, "Pierwszoosobowa" },
                    { 2, "Trzecioosobowa" },
                    { 3, "Fabularna" },
                    { 4, "Otwarty świat" },
                    { 5, "Science-Fiction" },
                    { 6, "Historyczna" },
                    { 7, "Zespołowa" },
                    { 9, "Wielu graczy" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "UserId", "CreatedDate", "FirstName", "IsActive", "LastName" },
                values: new object[] { 1, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Jan", true, "Kowalski" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImagePath", "ImageTypeId", "Name" },
                values: new object[,]
                {
                    { 12, "FFXIV_Endwalker_Amano_art215025516.jpg", 1, "FFXIV Endwalker" },
                    { 13, "Final_Fantasy_XVI_Key_Art215032567.png", 1, "FFXVI" },
                    { 14, "305a13f648147e862ed5e86d83d51dd6-98215049818.jpg", 1, "Control" },
                    { 15, "220px-FIFA_20_Cover214806118.jpg", 1, "test" },
                    { 16, "control_article214819163.jpg", 2, "Control_article" },
                    { 17, "valhalla_article214830763.jpg", 2, "valhalla_article" },
                    { 18, "final-fantasy-xvi-articlejpg214958970.jpg", 2, "ffxvi_article" },
                    { 19, "fifa21_article215010978.png", 2, "fifa21_article" },
                    { 21, "AssassinsCreed2_article215039580.jpg", 2, "assassinscreed2_article" },
                    { 11, "Mass_Effect_3_Game_Cover215010594.jpg", 1, "Mass Effect 3" },
                    { 22, "AssassinsCreed_article215049675.jpg", 2, "assassinscreed_article" },
                    { 23, "masseffect3_article215114959.jpg", 2, "masseffect3_article" },
                    { 24, "masseffect2_article215122820.jpg", 2, "masseffect2_article" },
                    { 25, "masseffect_article215131862.jpg", 2, "masseffect_article" },
                    { 26, "endwalker_article215345214.png", 2, "ffxivendwalker_article" },
                    { 27, "parrot214853179.jpg", 3, "Parrot" },
                    { 20, "Pokemon-Sword-and-Shield_article215022688.jpg", 2, "pokemonSword-article" },
                    { 10, "MassEffect2215000597.png", 1, "Mass Effect 2" },
                    { 9, "MassEffect214954176.jpg", 1, "Mass Effect" },
                    { 8, "Assassins-creed-valhalla-jaquette214926466.jpg", 1, "Assassins Creed Valhalla" },
                    { 7, "assassinscreed2214915719.jpg", 1, "Assassins Creed 2" },
                    { 6, "Sword_EN_boxart214902510.png", 1, "Pokemon Sword" },
                    { 5, "b05b3823508c28c8f8646e8bcc605b3e-98214849203.jpg", 1, "Cyberpunk 2077" },
                    { 4, "6034312b4499a2d8ae681e7ad74b5500-98214840748.jpg", 1, "Little Nightmares II" },
                    { 3, "220px-Assassin's_Creed214827007.jpg", 1, "Assassins Creed 1" },
                    { 2, "220px-FIFA_21_Cover214815562.jpg", 1, "FIFA 21" },
                    { 1, "220px-FIFA_20_Cover213828700.jpg", 1, "FIFA 20" }
                });

            migrationBuilder.InsertData(
                table: "Moderators",
                columns: new[] { "UserId", "CreatedDate", "IsActive", "LastLoginDate" },
                values: new object[] { 1, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "CompanyId", "IsActive", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 4, 5, true, "Switch", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, true, "3DS", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 14, true, "Xbox 360", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 14, true, "Xbox One", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 15, true, "Playstation 3", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 14, true, "PC ", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 15, true, "Playstation 4", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 15, true, "Playstation 5", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 14, true, "Xbox Series X", new DateTime(1994, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserLists",
                columns: new[] { "Id", "CreatedDate", "IsPublic", "ListTypeId", "Name", "UserId" },
                values: new object[] { 3, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Kupić", 1 });

            migrationBuilder.InsertData(
                table: "UserLists",
                columns: new[] { "Id", "CreatedDate", "IsPublic", "ListTypeId", "Name", "UserId" },
                values: new object[] { 1, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Dobre", 1 });

            migrationBuilder.InsertData(
                table: "UserLists",
                columns: new[] { "Id", "CreatedDate", "IsPublic", "ListTypeId", "Name", "UserId" },
                values: new object[] { 2, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Kiepskie", 1 });

            migrationBuilder.InsertData(
                table: "UserLists",
                columns: new[] { "Id", "CreatedDate", "IsPublic", "ListTypeId", "Name", "UserId" },
                values: new object[] { 4, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, "Gram", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "ImageId", "IsActive", "IsPublic", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisterDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 5, 0, "6931d766-59a6-42a4-9c40-3593ea2bdd4a", null, "b@b.pl", true, 27, true, true, true, null, "B@B.PL", "ANDRZEJ", "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==", null, false, new DateTime(2021, 3, 19, 23, 43, 35, 0, DateTimeKind.Unspecified), "XDQ77TTJDPKOJKPRKF6HKYC6Y7P2BCBN", false, "Andrzej" },
                    { 3, 0, "9aa3cb54-abbf-44df-88ad-442c79613fb5", null, "author@a.pl", true, 27, true, true, true, null, "AUTHOR@A.PL", "AUTHOR", "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==", null, false, new DateTime(2021, 3, 19, 23, 30, 20, 0, DateTimeKind.Unspecified), "TVMXT4TOQHJQYEPBI66U4Y6N5R2PN4BS", false, "Author" },
                    { 2, 0, "0e5dabda-21e1-41c3-9ca9-712557e18cb8", null, "moderator@a.pl", true, 27, true, true, true, null, "MODERATOR@A.PL", "MODERATOR", "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==", null, false, new DateTime(2021, 3, 19, 23, 30, 37, 0, DateTimeKind.Unspecified), "7DVGRSDTJBFLREA3JWKP5652YSSE65BW", false, "Moderator" },
                    { 4, 0, "397099b8-9228-42bf-b751-6e97fcd9101a", null, "c@c.pl", true, 27, true, true, true, null, "C@C.PL", "STEFAN", "AQAAAAEAACcQAAAAEG6cNJRSVylV3/tdiHn5UVECZMhhvHP7hT3fVxqTRzhpU9OJReOkZoHisfkoLk5W7Q==", null, false, new DateTime(2021, 3, 19, 23, 30, 54, 0, DateTimeKind.Unspecified), "6GTDRNU4VTDMTYWX7U66A57BT6ACCR3E", false, "Stefan" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "GenreId", "ImageId", "IsActive", "PlatformId", "PublisherId", "ReleaseDate", "SeriesId", "StatusId", "Title" },
                values: new object[,]
                {
                    { 13, "Control to trzecioosobowa strzelanka science fiction. Gracz musi zmierzyć się z inwazją sił nie z tego świata, a w walce z nimi wykorzystuje szereg zdolności specjalnych oraz telekinetyczny pistolet, który poza strzelaniem pozwala ciskać obiektami i przeciwnikami na odległość.", 7, 5, 14, true, 4, 6, new DateTime(2021, 10, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "Control" },
                    { 11, "Final Fantasy XVI to nadchodząca gra RPG akcji opracowana i wydana przez Square Enix na PlayStation 5. Jest to szesnasty tytuł z głównej serii Final Fantasy. Grę produkuje Naoki Yoshida, a reżyseruje ją Hiroshi Takai.", 16, 1, 13, true, 7, 16, null, 7, 1, "Final Fantasy XVI" },
                    { 10, "Final Fantasy XIV Endwalker trafi do nas jesienią 2021 roku i zakończy wątek fabularny rozwijany od 2013 roku. Jednocześnie będzie to początek zupełnie nowej historii. Od samych twórców dowiedzieliśmy się, że w trakcie przygody trafimy między innymi na księżyc, do stolicy imperium Garlemald oraz do miasta Radz-at - Han.", 16, 1, 12, true, 7, 16, new DateTime(2021, 11, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, "Final Fantasy XIV: Endwalker" },
                    { 3, "Fabularna gra akcji, trzecia część serii Mass Effect, stworzona przez studio BioWare, wydana przez Electronic Arts równocześnie na platformach Microsoft Windows, Xbox 360(z obsługą Kinecta) i PlayStation 3.Ogłoszona została 11 grudnia 2010 roku, a wersja demonstracyjna została udostępniona 14 lutego 2012 roku. Premiera gry nastąpiła 6 marca 2012 roku w Ameryce Północnej i 9 marca 2012 roku w Europie.W Polsce i Australii ukazała się 8 marca 2012 roku, a w Japonii 15 marca 2012 roku. Mass Effect 3 w przeciwieństwie do poprzednich części nie został wydany w pełnej polskiej wersji językowej z dubbingiem, a jedynie z polskimi napisami.", 2, 1, 11, true, 9, 1, new DateTime(2012, 3, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "Mass Effect 3" },
                    { 2, "Fabularna gra akcji stworzona przez BioWare, wydana przez Electronic Arts w styczniu 2010 roku na platformy Microsoft Windows i Xbox 360,  a rok później na konsolę PlayStation 3.Stanowi drugą część trylogii Mass Effect.Akcja rozgrywa się w XXII wieku w Drodze Mlecznej, gdzie ludzkości zagraża insektoidalna rasa Obcych znanych jako Zbieracze.Gracz wciela się w postać komandora Sheparda, elitarnego żołnierza sił ziemskich, który w celu pokonania zagrożenia musi skompletować oddział gotowy wziąć udział w misji samobójczej.Wczytując zapis z pierwszej części gracz może kształtować fabułę Mass Effect 2 na wiele sposobów.", 2, 1, 10, true, 9, 1, new DateTime(2010, 1, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "Mass Effect 2" },
                    { 1, "Komputerowa fabularna gra akcji stworzona przez studio BioWare, wydana pierwotnie w 2007 roku przez Microsoft Game Studios na konsolę Xbox 360, będąca pierwszą częścią serii Mass Effect.Jej akcja rozgrywa się w XXII wieku, kiedy Drodze Mlecznej grozi zagłada ze strony superzaawansowanej rasy maszyn znanych jako Żniwiarze.Gracz wciela się w komandora Sheparda, elitarnego żołnierza próbującego powstrzymać inwazję.Rozgrywka składa się z kilku głównych elementów: wykonywania zadań, walki, eksplorowania kosmosu i interakcji z bohaterami niezależnymi.", 2, 1, 9, true, 9, 1, new DateTime(2007, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "Mass Effect" },
                    { 5, "Głównym bohaterem gry jest Ezio Auditore da Firenze, młody szlachcic z bogatej florenckiej rodziny. Podobnie jak Altaïr ibn La-Ahad z pierwszej części gry,jest on praprzodkiem Desmonda Milesa, asasyna przetrzymywanego przez korporację Abstergo Industries. Fabuła rozpoczyna się we współczesności,kiedy Desmond i Lucy Stillman uciekają z Abstergo do kryjówki, gdzie spotykają się z innymi współczesnymi asasynami, Shaunem i Rebeką.W kryjówce Desmond korzysta z ulepszonej wersji animusa i przeżywa wspomnienia swojego przodka, aby przez Efekt Krwi nauczyć się być asasynem.", 4, 6, 7, true, 1, 3, new DateTime(2009, 11, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "Assassins Creed II" },
                    { 6, "Pokémon Sword i Pokémon Shield to gry RPG z 2019 roku opracowane przez Game Freak i opublikowane przez The Pokémon Company i Nintendo na Nintendo Switch. Są to pierwsze odsłony ósmej generacji serii gier wideo Pokémon i drugie z serii, po Pokémon: Lets Go, Pikachu!", 6, 1, 6, true, 4, 5, new DateTime(2019, 11, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Pokemon Sword" },
                    { 9, "Komputerowa fabularna gra akcji stworzona przez studio CD Projekt Red.  Stanowi adaptację papierowej gry fabularnej Cyberpunk 2020 i jest osadzona 57 lat później w otwartym świecie dystopijnego Night City.Akcja gry rozgrywa się w świecie przedstawionym z perspektywy pierwszej osoby.Główny bohater Cyberpunka, najemnik o imieniu V, wykonuje zadania, korzystając z umiejętności hakowania i obsługi maszyn, jak również z różnych rodzajów broni.", 11, 6, 5, true, 1, 11, new DateTime(2022, 11, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "Cyberpunk 2077" },
                    { 14, "Little Nightmares II to przygodowa gra logiczno-platformowa z gatunku horroru.", 8, 3, 4, true, 4, 8, null, null, 1, "Little Nightmares 2" },
                    { 4, "Przygodowa gra akcji stworzona przez studio Ubisoft Montreal i wydana w listopadzie 2007 roku na konsole PlayStation 3, Xbox 360 oraz w kwietniu 2008 roku na platformę Microsoft Windows.Akcja tytułu toczy się naprzemiennie w dwóch okresach czasowych: podczas III wyprawy krzyżowej, w roku 1191 oraz na początku września 2012 roku.Gracz wciela się w członka bractwa asasynów znanego jako Altaïr ibn La - Ahad, którego celem jest wyeliminowanie dziewięciu postaci propagujących wyprawy krzyżowe i odpowiedzialnych za cierpienia wielu ludzi.Gracz odwiedza pięć historycznych miejsc: Jerozolimę, Damaszek, Akkę, Masjaf oraz Arsuf.", 4, 6, 3, true, 1, 3, new DateTime(2007, 11, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "Assassins Creed" },
                    { 8, "FIFA 21 to gra wideo symulująca piłkę nożną wydana przez Electronic Arts w ramach serii FIFA. Jest to 28. odsłona serii FIFA i zostanie wydana 9 października 2021 roku na platformę Microsoft Windows, Nintendo Switch, PlayStation 4 i Xbox One.", 1, 4, 2, true, 7, 1, new DateTime(2021, 10, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "FIFA 21" },
                    { 12, "Przygodowa gra akcji wyprodukowana przez kanadyjskie studio Ubisoft Montréal, stanowiąca dwunastą główną odsłonę serii Assassin’s Creed i kontynuację Assassin’s Creed Odyssey. Akcja gry dzieje się w IX wieku w średniowiecznej Anglii.", 4, 6, 8, true, 3, 3, new DateTime(2021, 12, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "Assassins Creed Valhalla" },
                    { 7, "FIFA 20 jest komputerową grą sportową o tematyce piłki nożnej. Po raz czwarty w serii FIFA zastosowano silnik gry Frostbite. W grze pojawił się nowy tryb o nazwie „Volta”. Zmiany w mechanizmie rozgrywki zostały zaprezentowane 18 lipca 2019 roku.Wśród zmian względem poprzedniczki, gra posiada przebudowany system stałych fragmentów gry. Najważniejszą zmianą jest dodanie do mechanizmu wykonywania rzutów karnych i rzutów rożnych nowatorskiego systemu celowania i kontroli piłki, która według zapowiedzi twórców została zwiększona.", 1, 4, 1, true, 9, 1, new DateTime(2019, 11, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "FIFA 20" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleTypeId", "Content", "GameId", "ImageId", "IsActive", "Preview", "PublishedDate", "SourceLink", "Title", "UserId" },
                values: new object[,]
                {
                    { 3, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 3, 23, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2010, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 1 },
                    { 2, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 2, 24, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 1 },
                    { 4, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 4, 22, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2012, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 1 },
                    { 1, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 1, 25, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 1 },
                    { 5, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 5, 21, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 1 },
                    { 6, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 6, 20, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2017, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "UserId", "CreatedDate", "FirstName", "IsActive", "LastName" },
                values: new object[] { 3, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Adam", true, "Nowak" });

            migrationBuilder.InsertData(
                table: "Awards",
                columns: new[] { "Id", "AwardDate", "GameId", "Name" },
                values: new object[,]
                {
                    { 5, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, "Najlepsza fabuła 2012" },
                    { 3, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, "Gra roku 2012" },
                    { 2, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, "Gra roku 2010" },
                    { 4, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, "Najlepsza fabuła 2009" },
                    { 1, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, "Gra roku 2007" }
                });

            migrationBuilder.InsertData(
                table: "GameLanguage",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 5, 1 },
                    { 5, 3 },
                    { 5, 7 },
                    { 8, 1 },
                    { 11, 3 },
                    { 11, 1 },
                    { 12, 5 },
                    { 4, 6 },
                    { 10, 6 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 10, 4 },
                    { 10, 3 },
                    { 10, 2 },
                    { 10, 1 },
                    { 2, 1 },
                    { 3, 4 },
                    { 8, 2 },
                    { 4, 7 },
                    { 4, 8 },
                    { 3, 2 },
                    { 6, 2 },
                    { 14, 2 },
                    { 14, 3 },
                    { 14, 4 },
                    { 14, 5 }
                });

            migrationBuilder.InsertData(
                table: "GameLanguage",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { 14, 6 },
                    { 14, 7 },
                    { 9, 2 },
                    { 9, 4 },
                    { 9, 1 },
                    { 6, 1 },
                    { 13, 8 },
                    { 13, 7 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "GameLists",
                columns: new[] { "Id", "AddedDate", "EditedDate", "GameId", "HoursPlayed", "PersonalScore", "UserListId" },
                values: new object[,]
                {
                    { 24, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 14, null, 4 },
                    { 3, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 26, 5, 2 },
                    { 5, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 17, 6, 4 },
                    { 27, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 111, 8, 4 },
                    { 1, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 9, 8, 1 },
                    { 2, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 15, 9, 1 },
                    { 4, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 24, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "GameTag",
                columns: new[] { "GameId", "TagId" },
                values: new object[,]
                {
                    { 7, 9 },
                    { 3, 2 },
                    { 3, 3 },
                    { 11, 2 },
                    { 11, 4 },
                    { 10, 2 },
                    { 11, 8 },
                    { 13, 8 },
                    { 11, 3 },
                    { 10, 9 },
                    { 10, 3 },
                    { 10, 4 },
                    { 3, 8 },
                    { 13, 5 },
                    { 1, 8 },
                    { 5, 8 },
                    { 4, 8 },
                    { 14, 5 },
                    { 9, 1 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 8 },
                    { 6, 4 },
                    { 5, 2 },
                    { 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "GameTag",
                columns: new[] { "GameId", "TagId" },
                values: new object[,]
                {
                    { 7, 7 },
                    { 12, 2 },
                    { 4, 4 },
                    { 12, 8 },
                    { 8, 9 },
                    { 1, 2 },
                    { 1, 3 },
                    { 4, 2 },
                    { 12, 4 },
                    { 2, 8 },
                    { 8, 7 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Moderators",
                columns: new[] { "UserId", "CreatedDate", "IsActive", "LastLoginDate" },
                values: new object[] { 2, new DateTime(1991, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, null });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "EditDate", "GameId", "GameplayScore", "GraphicsScore", "ModeratorId", "MusicScore", "ReviewDate", "StoryScore", "UserId" },
                values: new object[,]
                {
                    { 12, "Są drobne bugi w grze, najczęściej zdarzało mi się, że nie mogłem podnosić różnych itemów. Postacie jak i auta kawałek się teleportują. Animacje postaci ludzią przeskakiwać tzn. jedna po drugiej nie są płynne.", null, 2, 5, 7, null, 3, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 6, "Na początku myślałem ,że to żart jak gra jest zabugowana no i jak działa ale... no i właśnie jest to ale po przestawieniu myślenia i wgłębieniu się w fabułę ciężko było mi oderwać się od fabuły zarówno głównej jak i pobocznej. Jedna z lepiej napisanych historii. Czy gra mogłaby być lepiej zoptymalizowana - jasne, czy powinno być mnie bugów i glitch - jasne.", null, 1, 5, 7, null, 4, new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 7, "Cyberpunk 2077. Jeżeli o mnie chodzi nie czułem jakiegoś mocnego hajpu na tę grę, nie czekałem na nią jakoś mocno, nawet nie planowałem jej kupić, a tym bardziej na premierę, bo nie jestem zwolennikiem kupowania gier zaraz po ich wyjściu, nie zapoznając się wcześniej z opiniami i recenzjami danej gry, jedyne co przyciągało moją uwagę to mocna kampania marketingowa i to że jest to gra polskiego studia CD projekt", new DateTime(2015, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 6, 1, 3, new DateTime(2015, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 10, "Zdecydowanie polecam ale nie będę kłamać że gra na obecną chwile jest idealna, zarzuty w kwestii większych lub mniejszych błędów są jak najbardziej prawdziwe, ale to wciąż dobrze wykreowany i zbudowany świat z dobrą historią i świetnymi postaciami. Moja ocena 7/10. Przyszłe patche naprawią grę i będzie 10/10 :)", null, 12, 7, 9, null, 9, new DateTime(2012, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4 },
                    { 14, "Zdecydowanie się nie zawiodłem, klimaty i oprawa gry jest dokładnie taka jak sobie wyobrażałem. Rozgrywka bardzo przyjemna zdecydowanie nie będziecie się nudzić na mapie jest mnóstwo aktywności. Mapa jest świetnie zrobiona Night City wygląda ja faktyczna cyberpunkowa metropolia. Niestety na tą chwilę ma duże problemy z optymalizacją i jest sporo błędów ale wierzę że za jakiś czas twórcy to naprawią. Gra zdecydowanie warta polecenia.", null, 7, 8, 8, null, 8, new DateTime(2018, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 5 },
                    { 8, "Gra stawia nowe filary w gamedevie, jeśli chodzi o wertykalną warstwę fabularną, czy też oprawę audiowizualną. Ogrywanie jej na RayTracingu to istne wzrokowe wodotryski, ale nie każdy portfel jest na tyle gruby, żeby ograć to w stabilnych 60 klatkach. Natomiast gra ma potężne wady, których nie jestem w stanie wybaczyć developerom.", new DateTime(2012, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 1, 1, 1, new DateTime(2012, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 9, "Sądzę, że po przegraniu 160h+ mogę w końcu się wypowiedzieć. Gra ma błędy. Ale nie są to błędy niszczące rozrywkę, w najgorszym przypadku wystarczy wgrać save i po sprawie. tym bardziej, że sejwy wgrywają się w parenaście-paredziesiąt sekund. Pod względem otwartego świata nie to parę rzeczy kuleje", null, 11, 7, 6, null, 7, new DateTime(2018, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 1, "Gra wciąga, jest ogromna ilość zadań które gracz może wykonać i polecam ją sprawdzić. Jak komuś nie zadziała to szybki zwrot na Steamie i powrót za pół roku po patchach. Osobiście nie myślałem, że gra CDPR mnie tak wciągnie, ale mam już za sobą kilkanaście godzin a zrobiłem może 10% fabuły. Gra jest na wiele godzin, może do końca lockdownu ją przejdę :D", null, 1, 7, 4, null, 8, new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 16, "Uwaga uwaga, gra ma bugi, kto by się spodziewał. Dobra to teraz o grze. Jest spoko, krótka, ale sporo zadań pobocznych. customizacja jest dość słaba, ale dobieranie zdolności i ogólnie aspekty RPG typu drzewka, statystyki broni itp są bardzo mocne. Grafika jest dobra, nawet na średnio niskich ustawieniach. Na pierwszym patchu w czasie jednej z misji pod koniec drugiego aktu gra się wysypywała, ale teraz nie ma większych problemów. Fabuła jest okej", null, 1, 8, 7, null, 9, new DateTime(2015, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 15, "Mimo kilku małych problemów nie przeszkodziło mi to z cieszenia się z gry. Przez 6 godzin grania musiałem wczytać checkpoint tylko raz przez jednego buga. Nowe patche mogą pomóc z optymalizacją więc polecam na nie czekać ( Patch 1.04 właśnie wiele problemów z optymalizacją naprawił )", null, 11, 10, 5, null, 6, new DateTime(2016, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 3, "Po 18 godzinach i kilku hotfixach muszę przyznać, że gra naprawdę jest coraz mniej zbugowana. Co do fabuły nie można się doczepić - wciąga i wzbudza emocje. Detale w tej grze stoją na najwyższym poziomie, przez co często zamiast skupić się na głównych questach, wolę czasami pochodzić po mieście i porobić coś bardziej oderwanego od ciągu fabuły. Genialna gra, słów brak by opisać wrażenia po tych kilkunastu godzinach gry. Kto się waha - niech się przemoże i kupi tę grę. To najlepiej wydane 200 zł na grę w moim życiu.", null, 3, 8, 7, null, 7, new DateTime(2017, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 2, "Zanim może zacznę piać z zachwytu jaka to nie jest wspaniała gra, to myślę że warto wytłumaczyć dlaczego tak twierdzę. Przede wszystkim Cyberpunk, od momentu zapowiedzi w 2013, ani trochę mnie nie zainteresował. Nie śledziłem żadnych newsów na temat powstawania gry, nie oglądałem materiałów promocyjnych, ani nie oglądałem pierwszych pokazów gameplay. Grę kupiłem spontanicznie około dwa tygodnie przed premierę, nastawiając się na nią bardzo neutralnie, śmiejąc się przy tym z wyolbrzymionych oczekiwań i hype na temat tej gry. Przechodząc jednak do recenzji...", null, 2, 5, 6, null, 6, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 4, "Najprawdopodobniej jedna z najlepszych gier jakie powstały. Idealnie pokazuje brudny cyberpunkowy świat przez co wczucie się w cały ten klimat przychodzi z łatwością. Gra ma swoje problemy (liczne bugi, niektóre bardziej upierdliwe, drugie mniej) ale fabularnie - jest miazga. Mimo wszystko, warto poczekać na łatki które naprawią zdecydowaną większość bugów, ale nie zmienia to faktu że dostaliśmy coś, na co warto było czekać.", null, 5, 8, 9, null, 5, new DateTime(2012, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 5, "Myślę że po 85 godzinach spędzonych w Night City, mogę wreszcie opisać jak czuję się z nowym tworem CD Projekt Red zwanym Cyberpunk 2077 bazowanym na papierowej grze fabularnej Cyberpunk 2020 stworzonej przez Mikea Pondsmitha. Po ośmiu latach w końcu doczekaliśmy się premiery gry na którą czekała bardzo dużą część graczy.", null, 9, 9, 10, null, 9, new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserLists",
                columns: new[] { "Id", "CreatedDate", "IsPublic", "ListTypeId", "Name", "UserId" },
                values: new object[,]
                {
                    { 6, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Porzucone", 2 },
                    { 5, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Ukończone", 2 },
                    { 12, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Planowane", 5 },
                    { 8, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Ukończone", 4 },
                    { 9, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Porzucone", 4 },
                    { 10, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Ukończone", 5 },
                    { 11, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Porzucone", 5 },
                    { 7, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Planowane", 2 },
                    { 13, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, "Grane", 5 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleTypeId", "Content", "GameId", "ImageId", "IsActive", "Preview", "PublishedDate", "SourceLink", "Title", "UserId" },
                values: new object[,]
                {
                    { 7, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 8, 19, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2016, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 3 },
                    { 8, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 10, 26, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 3 },
                    { 9, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 11, 18, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 3 },
                    { 10, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 12, 17, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 3 },
                    { 11, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", 13, 16, true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "link", "Tytuł artykułu", 3 }
                });

            migrationBuilder.InsertData(
                table: "GameLists",
                columns: new[] { "Id", "AddedDate", "EditedDate", "GameId", "HoursPlayed", "PersonalScore", "UserListId" },
                values: new object[,]
                {
                    { 26, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 742, 9, 8 },
                    { 21, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 0, null, 11 },
                    { 20, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, 0, null, 11 },
                    { 19, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 0, null, 11 },
                    { 18, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, 0, null, 11 },
                    { 17, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, 0, null, 11 },
                    { 16, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 0, null, 11 },
                    { 15, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 15, 10, 9 },
                    { 14, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 42, 2, 9 },
                    { 13, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 6, 10, 9 },
                    { 23, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 20, 4, 12 },
                    { 11, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 1, 7, 9 },
                    { 22, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 10, 9, 12 },
                    { 25, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 52, 7, 8 },
                    { 10, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 8, 1, 8 },
                    { 9, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 0, null, 7 },
                    { 8, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 0, null, 7 },
                    { 7, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 0, null, 7 },
                    { 6, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 12, 8, 5 },
                    { 12, new DateTime(2012, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 3, 10, 9 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "EditDate", "GameId", "GameplayScore", "GraphicsScore", "ModeratorId", "MusicScore", "ReviewDate", "StoryScore", "UserId" },
                values: new object[,]
                {
                    { 13, "Obcowanie z tą grą to sinusoida oceny. Od początkowego zachwytu (grafiką i klimatem), przez rozczarowanie (odkrywanie elementów, które są strasznie słabe), realizm (wady nie przesłaniają zalet), aż po zakochanie (zżycie z postaciami i siła emocji przesłaniają biedę innych elementów)", new DateTime(2015, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, 5, 2, 6, new DateTime(2014, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 5 },
                    { 11, "Dla tych co się zastanawiają nad kupnem gry na szybko..., jeśli nie przeszkadzają Ci wizualne błędy, a Twój komputer daje przysłowiowo radę, to bierz i nie zastanawiaj się. Ja osobiście w trakcie 50h gry nie uświadczyłem żadnego crasha, poważnych błędów lub zbugowanych questów. A nawet jeśli by się zdarzyło to dla mnie żaden problem dopóki nie jest to częste.", new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 7, 5, 2, 4, new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "GameLanguage",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GameLists",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "GameTag",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moderators",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moderators",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserLists",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImageTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ListTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ListTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ListTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ListTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ImageTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ImageTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
