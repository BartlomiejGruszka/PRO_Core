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

        public Pagination(int? page, int? items, int allItems)
        {
            if (!items.HasValue) PageItems = 5;
            else PageItems = items.Value;

            if (!page.HasValue) PageIndex = 1;
            else PageIndex = page.Value;

            TotalPages = (int)Math.Ceiling(allItems / (double)PageItems);

        }
    }
}