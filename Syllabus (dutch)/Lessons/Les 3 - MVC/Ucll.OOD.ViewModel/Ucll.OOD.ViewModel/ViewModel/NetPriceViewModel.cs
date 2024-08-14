namespace ViewModel.ViewModel;

public class NetPriceViewModel
{
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Item { get; set; }
        public decimal LineValue
        {
            get
            {
                return Quantity * Price;
            }
        }
}
