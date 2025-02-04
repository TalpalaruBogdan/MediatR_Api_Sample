using MediatR;
using MediatRSampleApi.Repository;
using MediatRSampleApi.Requests;

namespace MediatRSampleApi.Handlers;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, int>
{
     //Inject Validators 
     private readonly ICustomerRepository _customerRepository;

     public CreateCustomerHandler(ICustomerRepository customerRepository)
     {
          _customerRepository = customerRepository;
     }

     public async Task<int> Handle(CreateCustomerRequest request, 
          CancellationToken cancellationToken)
     {
          // First validate the request
          return await _customerRepository.AddCustomer(request.Customer);
     }
}