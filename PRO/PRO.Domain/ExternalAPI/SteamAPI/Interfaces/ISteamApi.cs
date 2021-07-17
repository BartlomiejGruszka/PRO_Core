
using PRO.Domain.ExternalAPI.SteamAPI.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PRO.Domain.ExternalAPI.SteamAPI
{
    public interface ISteamApi
    {
        public Task<AppList> GetAllSteamAppsJson();
        public List<SteamApp> GetAll();
        public List<SteamApp> GetAllByLetter(string letter);

        public List<string> GetFilterLetters();
        public UInt64 GetSteamUserId(string provider);
        public Task<UserSteamGames> CheckAppOwnership(int appid, UInt64 userid);

    }
}

