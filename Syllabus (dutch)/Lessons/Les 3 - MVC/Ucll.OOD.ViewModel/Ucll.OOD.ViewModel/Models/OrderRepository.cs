namespace ViewModel.Models;

public class OrderRepository
{
    private List<Order> _orders = new List<Order>
    {
        new Order
        {
            Id = 1,
            CustomerName = "Wim Vanden Broeck"
        },
        new Order
        {
            Id = 2,
            CustomerName = "Henk Verelst"
        }
    };
    private List<OrderDetail> _ordersDetail = new List<OrderDetail>
    {
        new OrderDetail
        {
            Id = 1,
            ItemCode = "ABC",
            OrderId = 1,
            Quantity = 5,
            UnitPrice = 15.5M
        },
        new OrderDetail
        {
            Id = 2,
            ItemCode = "ZED",
            OrderId= 1,
            Quantity = 3,
            UnitPrice = 20.5M
        },
        new OrderDetail
        {
            Id = 3,
            ItemCode = "ABC",
            OrderId = 2,
            Quantity = 4,
            UnitPrice = 15.5M
        },
        new OrderDetail
        {
            Id = 4,
            ItemCode = "ZED",
            OrderId = 2,
            Quantity = 10,
            UnitPrice = 20.5M
        }
     };

 
    public OrderRepository() { }


    public List<Order> GetOrders()
    {
        return _orders;
    }

    public List<OrderDetail> GetDetailOrders()
    {
        return _ordersDetail;
    }

    public List<OrderDetail> GetDetailOrdersForOrder(int orderId)
    {
        return _ordersDetail.Where(detail => detail.OrderId == orderId).ToList();
    }

}
