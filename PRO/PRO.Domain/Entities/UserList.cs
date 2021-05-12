using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class UserList
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Data utworzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Required, DisplayName("Nazwa"), MaxLength(50), MinLength(3)]
        [IndexColumn("UniqueUserList_IX", 1, IsUnique = true)]//add custom is unique constraint UniqueUserListUserIdAndName
        public string Name { get; set; }

        [Required, DisplayName("Dostępna publicznie")]
        public bool IsPublic { get; set; }

        [Required, DisplayName("Właściciel listy")]
        [IndexColumn("UniqueUserList_IX", 2, IsUnique = true)]
        public int UserId { get; set; }

        [ForeignKey("UserId"), DisplayName("Właściciel listy")]
        public ApplicationUser User { get; set; }

        [Required, DisplayName("Rodzaj listy")]
        public int ListTypeId { get; set; }

        [ForeignKey("ListTypeId"), DisplayName("Rodzaj listy")]
        public ListType ListType { get; set; }

        public ICollection<GameList> GameLists { get; set; }
    }
}