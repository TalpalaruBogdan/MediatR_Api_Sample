using MediatRSampleApi.Models;

namespace MediatRSampleApi.Repository;

public class CustomerRepository : ICustomerRepository
{
     private List<Customer> _customers;

     public CustomerRepository()
     {
          _customers = new List<Customer>();
          
          // Seed
          _customers.Add(new Customer()
          {
               Address = "test",
               EmailAddress = "test@test.com",
               FirstName = "test",
               LastName = "test"
          });
     }

     public async Task<int> AddCustomer(Customer customer)
     {
          _customers.Add(customer);
          return await Task.FromResult(_customers.IndexOf(customer));
     }
     
     public async Task<Customer?> GetCustomer(int id)
     {
          return await Task.FromResult(_customers[id]);
     }
}