using System.Threading.Tasks;

namespace LABMediatR.Repository
{
    using Models;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
    }
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<IEnumerable<Customer>> GetAll()
        {           
            var customers = new Collection<Customer>();
            for (int i = 0; i < 20; i++)           
                customers.Add(new Customer($"Paulo Pitte - {i}"));

            await Task.CompletedTask;
            return customers;
        }
    }
}
