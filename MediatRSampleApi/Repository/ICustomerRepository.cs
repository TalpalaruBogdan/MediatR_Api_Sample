using MediatRSampleApi.Models;

namespace MediatRSampleApi.Repository;

public interface ICustomerRepository
{
     Task<int> AddCustomer(Customer customer);
     Task<Customer?> GetCustomer(int id);
}