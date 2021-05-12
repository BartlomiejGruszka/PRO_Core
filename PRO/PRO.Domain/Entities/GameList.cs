using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class GameList
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Data dodania")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedDate { get; set; }

        [DisplayName("Data edycji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EditedDate { get; set; }

        [Required, DisplayName("Rozegrane godziny"), Range(0,99999)]
        public int? HoursPlayed { get; set; }

        [DisplayName("Własna ocena")]//PersonalScoreRange
        public int? PersonalScore { get; set; }

        [Required, DisplayName("Lista użytkownika")]
        [IndexColumn("UniqueGameList_IX", 1, IsUnique = true)]//add custom is unique constraint UniqueGameAndUserList
        public int UserListId { get; set; }

        [ForeignKey("UserListId"), DisplayName("Lista użytkownika")]
        public UserList UserList{ get; set; }

        [Required, DisplayName("Gra")]
        [IndexColumn("UniqueGameList_IX", 2, IsUnique = true)]//add custom is unique constraint UniqueGameAndUserList
        public int GameId { get; set; }

        [ForeignKey("GameId"), DisplayName("Gra")]
        public Game Game { get; set; }

    }
}