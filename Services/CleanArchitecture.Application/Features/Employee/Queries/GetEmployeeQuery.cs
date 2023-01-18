using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
namespace CleanArchitecture.Application.Features.Employee.Queries
{
    public class GetEmployeeQuery : IRequest<List<Domain.Entities.Employee>>
    {
    }
}
