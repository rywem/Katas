using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    /// <summary>
    /// Reference: https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    /// </summary>
    public class OrderBuilder
    {
        private Order _order = new Order();

        public OrderBuilder Id(int id)
        {
            _order.Id = id;
            return this;
        }

        public OrderBuilder Amount(decimal totalAmount)
        {
            _order.TotalAmount = totalAmount;
            return this;
        }

        public Order Build()
        {
            return _order;
        }

        public OrderBuilder Customer(Customer customer)
        {
            _order.Customer = customer;
            return this;
        }

        public OrderBuilder WithTestValues()
        {
            _order.TotalAmount = 100m;
            _order.Id = 0;

            CustomerBuilder customerbuilder = new CustomerBuilder();

            _order.Customer = customerbuilder
                               .Id(10)
                               .WithTestValues()
                               .Build();
         
            return this;
        }
    }
}
