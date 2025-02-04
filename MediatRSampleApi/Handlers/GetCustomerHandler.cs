using MediatR;
using MediatRSampleApi.Models;
using MediatRSampleApi.Repository;
using MediatRSampleApi.Requests;

namespace MediatRSampleApi.Handlers;

public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, Customer>
{  
     private readonly ICustomerRepository _customerRepository;

     public GetCustomerHandler(ICustomerRepository customerRepository)
     {
          _customerRepository = customerRepository;
     }
     
     public async Task<Customer> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
     {
          return await _customerRepository.GetCustomer(request.CustomerId);
     }
}