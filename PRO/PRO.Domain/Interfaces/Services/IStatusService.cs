using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        public void Add(Status status);
        public void Delete(Status status);

        public void Update(Status status);
        public ModelStateDictionary ValidateStatus(Status status);
    }
}
