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
        private readonly AddressBuilder _addressBuilder = new AddressBuilder();
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
                        .WithTestValues()
                        .Customer(null)
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
                            .WithTestValues()
                            .Id(customerId)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenAddressIsNull()
        {            
            var customer = _customerBuilder
                            .WithTestValues()
                            .Address(null)
                            .Build();

            var order = _orderBuilder
                        .Amount(10)
                        .Id(0)
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }


        [Fact]
        public void ThrowsExceptionGivenFirstNameIsEmpty()
        {
            var customer = _customerBuilder
                            .WithTestValues()                            
                            .FirstName(string.Empty)
                            .Build();

            var order = _orderBuilder
                        .Amount(10)
                        .Id(0)
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenLastNameIsEmpty()
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .LastName(string.Empty)
                            .Build();

            var order = _orderBuilder
                        .Amount(10)
                        .Id(0)
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionIfCreditRating200OrLess()
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .CreditRating(100)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            Assert.Throws<InsufficientCreditException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionIfTotalPurchasesLessThan0()
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .TotalPurchases(-1)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowsExceptionIfAddressStreetIsNullOrEmpty(string input)
        {
            var address = _addressBuilder
                          .WithTestValues()
                          .Street1(input)
                          .Build();

            var customer = _customerBuilder
                            .WithTestValues()
                            .Address(address)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidAddressException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowsExceptionIfAddressCityIsNullOrEmpty(string input)
        {
            var address = _addressBuilder
                          .WithTestValues()
                          .City(input)
                          .Build();

            var customer = _customerBuilder
                            .WithTestValues()
                            .Address(address)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidAddressException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowsExceptionIfAddressStateIsNullOrEmpty(string input)
        {
            var address = _addressBuilder
                          .WithTestValues()
                          .State(input)
                          .Build();

            var customer = _customerBuilder
                            .WithTestValues()
                            .Address(address)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            Assert.Throws<InvalidAddressException>(() => _orderService.PlaceOrder(order));
        }
    }
}
