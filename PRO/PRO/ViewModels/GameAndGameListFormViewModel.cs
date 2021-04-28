

using System.Collections.Generic;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class GameAndGameListFormViewModel
    {
        public Game Game { get; set; }
        public GameList GameList { get; set; }
        public List<UserList> userLists { get; set; }

        public int Popularity { get; set; }
        public int? Position { get; set; }
        public double? Rating { get; set; }
    }
}