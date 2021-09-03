using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PRO.Domain.ExternalAPI.SteamAPI.Entities;
using PRO.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.ExternalAPI.SteamAPI
{
    public class SteamApi : ISteamApi
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;
        private static bool ConnectionErrorLock = false;

        public SteamApi(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }


        public async Task<AppList> GetAllSteamAppsJson()
        {
            using (var client = new HttpClient())
            {
                var url = new Uri("https://api.steampowered.com/ISteamApps/GetAppList/v2/");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<AppList>(json);
                return result;
            }
        }
        public List<SteamApp> GetAll()
        {
            var allapps = GetAllSteamAppsJson().Result;
            var steamapps = allapps.applist.apps;
            return steamapps;

        }

        public List<SteamApp> GetAllByLetter(string letter)
        {
            var allapps = GetAll();
            var byletter = allapps
                .Where(s => s.name.ToLower().StartsWith(letter.ToLower()))
                .ToList();
            return byletter;

        }
        public List<string> GetFilterLetters()
        {
            List<string> filterstrings = new List<string>();
            var chararray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var numberarray = "0123456789".ToCharArray();
            foreach (var item in chararray)
            {
                foreach (var item2 in chararray)
                {
                    var str = item.ToString() + item2.ToString();
                    filterstrings.Add(str);
                }
            }
            foreach (var number in numberarray)
            {
                filterstrings.Add(number.ToString());
            }
            return filterstrings;
        }

        public UInt64 GetSteamUserId(string provider)
        {
            if (string.IsNullOrEmpty(provider)) return 0;
            string[] substrings = provider.Split("/");
            string useridstring = substrings.Last();
            UInt64 steamuserid = UInt64.Parse(useridstring);
            return steamuserid;
        }

        public string GetUserSteamProvider(List<UserLoginInfo> logins)
        {
            UserLoginInfo steamlogin = logins.Where(s => s.ProviderDisplayName.Equals("Steam")).SingleOrDefault();
            return steamlogin?.ProviderKey;
        }

        public async Task<UserSteamGames> GetUserSteamGames(UInt64 userid, int? appid)
        {


            using (var client = new HttpClient())
            {
                var url = new Uri(UserSteamGamesUrl(userid, appid));
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        ConnectionErrorLock = true;
                        return null;
                    }
                    json = await content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<UserSteamGames>(json);
                return result;
            }
        }

        public string UserSteamGamesUrl(UInt64 userid, int? appid)
        {
            var apikey = _config["SteamApiKey"];
            var sb = new StringBuilder();
            sb.Append("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1?key=");
            sb.Append(apikey);
            sb.Append("&steamid=");
            sb.Append(userid);
            sb.Append("&include_appinfo=0&include_played_free_games=1");
            sb.Append("&appids_filter[0]=");
            sb.Append(appid);

            return sb.ToString();
        }


        public async Task<bool> CheckAppOwnershipAsync(int? userid, int? appid)
        {
            if (_config["SteamApiKey"] == null || ConnectionErrorLock == true || appid == null) return false;
            var logins = _userService.GetUserLoginsAsync(userid);
            var provider = GetUserSteamProvider(logins.Result);
            var steamid = GetSteamUserId(provider);
            if (steamid == 0) return false;
            var games = await GetUserSteamGames(steamid, appid);
            if (games == null) return false;
            var result = games.SteamGames.SteamAppPlaytimes.Any(s => s.AppId == appid) ? true : false;
            return result;


        }
    }
}
