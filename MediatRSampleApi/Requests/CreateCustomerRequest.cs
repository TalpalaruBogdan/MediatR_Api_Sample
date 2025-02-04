using MediatR;
using MediatRSampleApi.Models;

namespace MediatRSampleApi.Requests;

public class CreateCustomerRequest : IRequest<int>
{
     public Customer Customer { get; set; }
}