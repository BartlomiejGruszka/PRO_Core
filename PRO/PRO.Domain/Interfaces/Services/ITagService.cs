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
        public void Add(Tag tag);
        public void Delete(Tag tag);

        public void Update(Tag tag);
    }
}
