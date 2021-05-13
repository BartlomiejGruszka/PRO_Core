using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IListTypeService
    {
        public IEnumerable<ListType> GetAll();
        public ListType Find(int? id);
        public void Add(ListType listType);
        public void Delete(ListType listType);

        public void Update(ListType listType);
        public ModelStateDictionary ValidateListType(ListType listType);
    }
}
