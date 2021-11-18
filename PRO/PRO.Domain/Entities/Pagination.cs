using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class Pagination
    {

        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int PageItems { get; set; }
        public string Action { get; set; }
        public int? RouteId { get; set; }
        public string FilterType { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public Pagination(int? page, int? items, int allItems)
        {
            if (!items.HasValue) PageItems = 5;
            else PageItems = items.Value;

            if (!page.HasValue) PageIndex = 1;
            else PageIndex = page.Value;

            TotalPages = (int)Math.Ceiling(allItems / (double)PageItems);

        }

        public void Configure(string action, int? routeid, string filtertype, string currentfilter, string sort)
        {
            Action = action;
            RouteId = routeid;
            FilterType = filtertype;
            CurrentFilter = currentfilter;
            CurrentSort = sort;
        }
        public void Configure(string action, int? routeid)
        {
            Action = action;
            RouteId = routeid;

        }
        public void Configure(string action, string currentfilter, string sort)
        {
            Action = action;
            CurrentFilter = currentfilter;
            CurrentSort = sort;

        }
    }
}