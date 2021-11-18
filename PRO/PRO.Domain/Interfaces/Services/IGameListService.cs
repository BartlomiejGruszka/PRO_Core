using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IGameListService
    {
        public IEnumerable<GameList> GetAll();
        public GameList Find(int? id);
        public void Add(GameList gameList);
        public void Delete(GameList gameList);

        public void Update(GameList gameList);

        public GameList AddOrUpdateDates(GameList gameList);
        public void AddOrUpdate(GameList gameList);
        public int? GetUserReviewPlaytime(Review review);
        public List<Tuple<GameList, DateTime>> GetRecentUserGameListUpdates(int userid, int? number);

        public ModelStateDictionary ValidateGameList (GameList gameList);
        IQueryable<GameList> FilterSearch(string query);
        IQueryable<GameList> OwnerGameLists( int? id);
        IQueryable<GameList> SortList(string sortOrder, IQueryable<GameList> gameLists);
        IQueryable<GameList> FilterByList(string filterType, string filterContent, IQueryable<GameList> gamelists);
        bool UserDelete(int id);
    }
}
