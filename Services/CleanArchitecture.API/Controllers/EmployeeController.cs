using CleanArchitecture.Application.Features.Employee.Queries;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet, ActionName("get")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployee()
        {

            try
            {
                var query = new GetEmployeeQuery();

                Dictionary<string, object> result = new Dictionary<string, object>();
                var response = await _mediator.Send(query);
                result["data"] = response;
                result["message"] = "success";

                result["totalrecords"] = response.Count;

                return Ok(result);
            }
            catch (Exception ex)
            {

                Dictionary<string, object> result = new Dictionary<string, object>();


                result["message"] = ex.Message;

             

                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
        }

    }
}
