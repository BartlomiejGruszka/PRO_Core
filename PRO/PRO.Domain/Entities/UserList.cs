using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Domain.Entities
{
    public class UserList
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data utworzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Nazwa"), IndexColumn("UniqueUserList_IX", 1, IsUnique = true)]//add custom is unique constraint UniqueUserListUserIdAndName
        public string Name { get; set; }

        [Required, DisplayName("Dostępna publicznie")]
        public bool IsPublic { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Właściciel listy")]
        [IndexColumn("UniqueUserList_IX", 2, IsUnique = true)]
        public int UserId { get; set; }

        [ForeignKey("UserId"), DisplayName("Właściciel listy")]
        public ApplicationUser User { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Rodzaj listy")]
        public int ListTypeId { get; set; }

        [ForeignKey("ListTypeId"), DisplayName("Rodzaj listy")]
        public ListType ListType { get; set; }

        public ICollection<GameList> GameLists { get; set; }
    }
}