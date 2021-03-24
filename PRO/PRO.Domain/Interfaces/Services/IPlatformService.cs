using PRO.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IPlatformService
    {
        public IEnumerable<Platform> GetAll();
        public Platform Find(int? id);
        public void Add(Platform tag);
        public void Delete(Platform tag);

        public void Update(Platform tag);
    }
}
