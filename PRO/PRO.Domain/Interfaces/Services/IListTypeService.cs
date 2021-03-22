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
        public void Add(ListType imageType);
        public void Delete(ListType imageType);

        public void Update(ListType imageType);
    }
}
