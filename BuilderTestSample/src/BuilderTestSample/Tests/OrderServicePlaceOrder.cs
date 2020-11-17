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

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowsExceptionIfAddressPostalCodeIsNullOrEmpty( string input )
        {
            var address = _addressBuilder
                          .WithTestValues()
                          .PostalCode(input)
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
        public void ThrowsExceptionIfAddressCountryIsNullOrEmpty( string input )
        {
            var address = _addressBuilder
                          .WithTestValues()
                          .Country(input)
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
        [InlineData(4999, 550)]
        [InlineData(5500, 490)]
        [InlineData(4900, 490)]
        [InlineData(5000, 500)]
        public void IsExpeditedIsFalse_TotalPurchaseLessThanOrEqual5000_and_CreditRaitngLessThanOrEqualTo500(decimal totalPurchases, int creditRating)
        {            

            var customer = _customerBuilder
                            .WithTestValues()
                            .TotalPurchases(totalPurchases)
                            .CreditRating(creditRating)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();
            
            _orderService.PlaceOrder(order);

            Assert.False(order.IsExpedited);
        }
        
        [Fact]
        public void IsExpeditedIsTrue_TotalPurchaseGreaterThanOrEqual5000_and_CreditRaitngGreaterThanOrEqualTo500()
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .TotalPurchases(5500)
                            .CreditRating(550)
                            .Build();

            var order = _orderBuilder
                        .WithTestValues()
                        .Customer(customer)
                        .Build();

            _orderService.PlaceOrder(order);

            Assert.True(order.IsExpedited);
        }
    }
}
