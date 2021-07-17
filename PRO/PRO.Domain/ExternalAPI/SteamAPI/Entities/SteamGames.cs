using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.ExternalAPI.SteamAPI.Entities
{
    class SteamGames
    {
        [JsonProperty(PropertyName = "games")]
        List<SteamAppPlaytimes> SteamAppPlaytimes { get; set; }

        [JsonProperty(PropertyName = "game_count")]
        public int Count { get; set; }
    } 
}
