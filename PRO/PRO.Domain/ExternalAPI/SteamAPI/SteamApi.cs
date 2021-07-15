using Newtonsoft.Json;
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
                foreach(var item2 in chararray)
                {
                    var str = item.ToString() + item2.ToString();
                    filterstrings.Add(str);
                }
            }
            foreach(var number in numberarray)
            {
                filterstrings.Add(number.ToString());
            }
            return filterstrings;
        }
    }
}
