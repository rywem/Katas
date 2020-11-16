using BuilderTestSample.Exceptions;
using BuilderTestSample.Services;
using BuilderTestSample.Tests.TestBuilders;
using Xunit;

namespace BuilderTestSample.Tests
{
    public class OrderServicePlaceOrder
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly OrderBuilder _orderBuilder = new OrderBuilder();
        private readonly CustomerBuilder _customerBuilder = new CustomerBuilder();
        [Fact]
        public void ThrowsExceptionGivenOrderWithExistingId()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Id(123)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ThrowsExceptionGivenOrderWith0Amount(decimal amount)
        {
            var order = _orderBuilder
                        .WithTestValues()
                        .Amount(amount)
                        .Id(0)
                        .Build();
            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenNullCustomer()
        {
            var order = _orderBuilder                        
                        .Amount(10)
                        .Id(0)
                        .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ThrowsExceptionGivenCustomerIdIs0(int customerId)
        {
            var customer = _customerBuilder
                            .Id(customerId)
                            .Build();

            var order = _orderBuilder
                        .Amount(10)
                        .Id(0)
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }
    }
}
