using PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Entities;
namespace PRO.ViewModels
{
    public class ReviewPlaytimeViewModel
    {
        public Review Review { get; set; }
        public int? Playtime { get; set; }
    }
}