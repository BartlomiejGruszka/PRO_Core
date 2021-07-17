using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.ExternalAPI.SteamAPI.Entities
{
    class SteamAppPlaytimes
    {
        [JsonProperty(PropertyName = "appid")]
        public int AppId { get; set; }

        [JsonProperty(PropertyName = "playtime_forever")]
        public int Playtime { get; set; }

        [JsonProperty(PropertyName = "playtime_windows_forever")]
        public int Playtime_Windows { get; set; }

        [JsonProperty(PropertyName = "playtime_mac_forever")]
        public int Playtime_Mac { get; set; }

        [JsonProperty(PropertyName = "playtime_linux_forever")]
        public int Playtime_Linux { get; set; }
    }
}
