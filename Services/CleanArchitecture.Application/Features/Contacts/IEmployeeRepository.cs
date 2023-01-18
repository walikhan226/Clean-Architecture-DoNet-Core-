
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanArchitecture.Application.Features.Contacts
{
    public interface IEmployeeRepository
    {

       public Task<List<Domain.Entities.Employee>> GetEmployees();
    }
}
