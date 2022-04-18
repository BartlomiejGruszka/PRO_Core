using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface ITagService
    {
        public IEnumerable<Tag> GetAll();
        public Tag Find(int? id);
        public void Add(Tag tag);
        public void Delete(Tag tag);

        public void Update(Tag tag);
        public ModelStateDictionary ValidateTag(Tag tag);
        IQueryable<Tag> SortList(string sortOrder, IQueryable<Tag> tags);
        IQueryable<Tag> FilterSearch(string query);
    }
}
