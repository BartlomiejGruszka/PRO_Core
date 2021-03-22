using PRO.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IStatusService
    {
        public IEnumerable<Status> GetAll();
        public Status Find(int? id);
        public void Add(Status imageType);
        public void Delete(Status imageType);

        public void Update(Status imageType);
    }
}
