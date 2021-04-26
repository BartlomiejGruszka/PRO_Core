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

        public int? GetUserReviewPlaytime(Review review);
    }
}
