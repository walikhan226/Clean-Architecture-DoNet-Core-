using CleanArchitecture.Application.Features.Contacts;
using CleanArchitecture.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        HrDbContext hrDbContext;

        public EmployeeRepository(HrDbContext hrDbContext)
        {
            this.hrDbContext = hrDbContext;
        }

        public Task<List<Domain.Entities.Employee>> GetEmployees()
        {
            return Task.FromResult(hrDbContext.Employees.ToList());
        }
    }
}
