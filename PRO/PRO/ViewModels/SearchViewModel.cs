using PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Entities;
namespace PRO.ViewModels
{
    public class SearchViewModel
    {
        public GameFilterViewModel GameFilterViewModel { get; set; }


        public Pagination Pagination { get; set; }
    }
}