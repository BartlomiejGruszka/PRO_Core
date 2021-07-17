using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.ExternalAPI.SteamAPI.Entities
{
    public class UserSteamGames
    {
        [JsonProperty(PropertyName = "response")]
        public SteamGames SteamGames { get; set; }
    }
}
