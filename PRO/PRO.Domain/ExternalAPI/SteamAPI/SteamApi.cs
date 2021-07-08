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
        public async Task<AppList> GetAllSteamApps()
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
                return JsonConvert.DeserializeObject<AppList>(json);
            }
        }
    }
}
