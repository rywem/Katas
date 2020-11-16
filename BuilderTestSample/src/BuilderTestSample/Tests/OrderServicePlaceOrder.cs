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
    }
}
