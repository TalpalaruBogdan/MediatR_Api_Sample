using MediatR;
using MediatRSampleApi.Models;

namespace MediatRSampleApi.Requests;

public class GetCustomerRequest : IRequest<Customer>
{
     public int CustomerId { get; set; }
}