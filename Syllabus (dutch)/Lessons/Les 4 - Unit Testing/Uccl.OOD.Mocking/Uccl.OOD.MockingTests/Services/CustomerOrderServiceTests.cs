using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uccl.OOD.Mocking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uccl.OOD.Mocking.Data;
using Moq;
using Uccl.OOD.Mocking.Data.DTO;

namespace Uccl.OOD.Mocking.Services.Tests;

[TestClass()]
public class CustomerOrderServiceTests
{
    private readonly CustomerOrderService _customerOrderService;
    private readonly Mock<IOrderRepository> _orderRepositoryMock = new Mock<IOrderRepository>();
    private readonly Mock<ICustomerRepository> _customerRepositoryMock = new Mock<ICustomerRepository>();

    public CustomerOrderServiceTests()
    {
        _customerOrderService = new CustomerOrderService(_customerRepositoryMock.Object, _orderRepositoryMock.Object);
    }
    [TestMethod()]
    public void GetCustomerDetailModelTotalPriceTest()
    {
        //CustomerOrderService uses the GetCustomerById method of ICustomerRepository
        //We will mock this method

        //1. Create the object that we will return
        var customer = new Customer
        {
            Id = 1,
            Name = "Wim Vanden Broeck",
            Email = "wim.vandenbroeck@ucll.be"
        };

        //2. Mock the method
        _customerRepositoryMock.Setup(x => x.GetCustomerById(1)).Returns(customer);

        //CustomerOrderService uses the ForCustomer method of IOrderRepository
        //We will also mock this method

        //1. Create the object that we will return
        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1250, Quantity = 1, CustomerId = 1 },
            new Order { Id = 1, ProductName = "Keyboard", Price = 33.33, Quantity = 2, CustomerId = 1}
        };

        //2. Mock the method
        _orderRepositoryMock.Setup(x => x.ForCustomer(1)).Returns(orders);


        var model = _customerOrderService.GetCustomerDetailModel(1);
        Assert.AreEqual(1316.66, model.TotalPrice);
    }
}
