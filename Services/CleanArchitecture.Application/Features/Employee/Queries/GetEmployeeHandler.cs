using CleanArchitecture.Application.Features.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Employee.Queries
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, List<Domain.Entities.Employee>>
    {
       private readonly  IEmployeeRepository _employeeRepository;

        public GetEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

      async  public Task<List<Domain.Entities.Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return  await  _employeeRepository.GetEmployees();
        }
    }
}
