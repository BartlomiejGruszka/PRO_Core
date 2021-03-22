using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAll();
        public Company Find(int? id);
        public void Add(Company imageType);
        public void Delete(Company imageType);

        public void Update(Company imageType);
    }
}
