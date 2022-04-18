using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Entities
{
    public class PaginatedList<T> : List<T>
    {
        public Pagination Pagination { get; set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            Pagination = new Pagination(pageIndex, pageSize, count);
            this.AddRange(items);
        }

        public static PaginatedList<T> Create(IQueryable<T> source, int? pageIndex, int? pageSize)
        {
            var count = source.Count();
    
            if (!pageSize.HasValue) { pageSize = 5; }
            if (pageSize.Value < 0) { pageSize = 5; }

            if (!pageIndex.HasValue) { pageIndex = 1; }
            if (pageIndex.Value < 1) pageIndex = 1;
            if (pageIndex * pageSize - count >= pageSize) { pageIndex = 1; }

            var items = source.Skip((pageIndex.Value - 1) * pageSize.Value).Take(pageSize.Value).ToList();

            return new PaginatedList<T>(items, count, pageIndex.Value, pageSize.Value);
        }

    }
}
