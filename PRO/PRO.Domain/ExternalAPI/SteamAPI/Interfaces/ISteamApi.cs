
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PRO.Domain.ExternalAPI.SteamAPI
{
     public interface ISteamApi
    {
       public Task<AppList> GetAllSteamApps();
        
    }
}

