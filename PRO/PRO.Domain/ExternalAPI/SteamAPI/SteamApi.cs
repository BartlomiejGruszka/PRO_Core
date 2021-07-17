using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PRO.Domain.ExternalAPI.SteamAPI.Entities;
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
        public SteamApi(IConfiguration config)
        {
            _config = config;
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
            string[] substrings = provider.Split("/");
            string useridstring = substrings.Last();
            UInt64 steamuserid = UInt64.Parse(useridstring);
            return steamuserid;
        }

        public string GetUserSteamProvider(List<UserLoginInfo> logins)
        {
            UserLoginInfo steamlogin = logins.Where(s => s.ProviderDisplayName.Equals("Steam")).SingleOrDefault();
            return steamlogin.LoginProvider;
        }

        public async Task<UserSteamGames> CheckAppOwnership(int appid, UInt64 userid)
        {
            userid = 76561198000072715;
            appid = 4580;
            var apikey = _config["SteamApiKey"];

            using (var client = new HttpClient())
            {
                var url = new Uri("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1?key="+ apikey + "&steamid="+userid+"&include_appinfo=false&include_played_free_games=false&appids_filter="+appid);
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<UserSteamGames>(json);
                return result;
            }
        }
    }
}
