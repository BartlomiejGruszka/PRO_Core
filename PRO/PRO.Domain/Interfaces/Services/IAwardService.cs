using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IAwardService
    {
        public IEnumerable<Award> GetAll();
        public Award Find(int? id);
        public void Add(Award award);
        public void Delete(Award award);

        public void Update(Award award);
    }
}
