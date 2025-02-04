using MediatR;
using MediatRSampleApi.Models;
using MediatRSampleApi.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MediatRSampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
     private readonly IMediator _mediator;

     public CustomerController(IMediator mediator)
     {
          _mediator = mediator;
     }
     
     [HttpGet("{customerId}")]
     public async Task<Customer?> GetCustomerAsync(int customerId)
     {
          var customerDetails = await _mediator.Send(new GetCustomerRequest() { CustomerId = customerId});

          return customerDetails;
     }

     [HttpPost]
     public async Task<int> CreateCustomerAsync(Customer customer)
     {
          var customerId = await _mediator.Send(new CreateCustomerRequest() { Customer = customer});
          return customerId;
     }
}