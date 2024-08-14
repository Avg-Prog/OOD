using Uccl.OOD.Mocking.Data.DTO;

namespace Uccl.OOD.Mocking.Models;

public class CustomerDetailModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }

    public int OrderCount
    {
        get
        {
            return Orders.Count;
        }
    }

    public double TotalPrice
    {
        get
        {
            double totalPrice = 0;
            foreach (var order in Orders)
            {
                totalPrice += order.Quantity * order.Price;
            }
            return totalPrice;
        }
    }
}
