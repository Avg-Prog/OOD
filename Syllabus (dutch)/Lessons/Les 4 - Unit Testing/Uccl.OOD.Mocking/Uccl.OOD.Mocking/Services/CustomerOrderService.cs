using Uccl.OOD.Mocking.Data;
using Uccl.OOD.Mocking.Data.DTO;
using Uccl.OOD.Mocking.Models;

namespace Uccl.OOD.Mocking.Services;

public class CustomerOrderService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IOrderRepository _orderRepository;

    public CustomerOrderService(ICustomerRepository customerRepository, IOrderRepository orderRepository)
    {
        _customerRepository = customerRepository;   
        _orderRepository = orderRepository;
    }

    public List<Customer> GetCustomers()
    {
        return _customerRepository.GetCustomers();
    }

    public CustomerDetailModel GetCustomerDetailModel(int customerId)
    {
        var customer = _customerRepository.GetCustomerById(customerId);
        var orders = _orderRepository.ForCustomer(customerId);

        return new CustomerDetailModel
        {
            Customer = customer!,
            Orders = orders
        };
    }
}
