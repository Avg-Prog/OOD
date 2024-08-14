using Uccl.OOD.Mocking.Data.DTO;

namespace Uccl.OOD.Mocking.Data;

public interface IOrderRepository
{
    public List<Order> GetAll();
    public List<Order> ForCustomer(int customerId);
}
