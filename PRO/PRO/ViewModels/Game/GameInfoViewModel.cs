

using System.Collections.Generic;
using PRO.Domain.Entities;
namespace PRO.UI.ViewModels
{
    public class GameInfoViewModel
    {
        public Game Game { get; set; }
        public List<UserList> UserLists { get; set; }

        public int Popularity { get; set; }
        public int? Position { get; set; }
        public double? Rating { get; set; }
    }
}