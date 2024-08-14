using Uccl.OOD.Mocking.Data.DTO;

namespace Uccl.OOD.Mocking.Data;

public interface ICustomerRepository
{
    public List<Customer> GetCustomers();

    public Customer? GetCustomerById(int id);
}
