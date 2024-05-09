using CRMSERVER1.Application.Features.Customers;
using CRMSERVER1.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRMSERVER1.WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class CustomersController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        List<Customer> customers=await mediator.Send(new GetAllCustomerQuery(), cancellationToken);
        return Ok(customers);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCustomerCommand request,CancellationToken cancellationToken)
    {
        await mediator.Send(request, cancellationToken);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCustomerCommand request,CancellationToken cancellationToken)
    {
        await mediator.Send(request, cancellationToken);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteCustomerByIdCommand request,CancellationToken cancellationToken)
    {
       

        await mediator.Send(request, cancellationToken);
        return Ok();
    }

}
