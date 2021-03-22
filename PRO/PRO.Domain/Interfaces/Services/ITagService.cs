using PRO.Entities;
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
        public void Add(Tag imageType);
        public void Delete(Tag imageType);

        public void Update(Tag imageType);
    }
}
