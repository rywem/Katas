using BuilderTestSample.Exceptions;
using BuilderTestSample.Model;

namespace BuilderTestSample.Services
{
    public class OrderService
    {
        public void PlaceOrder(Order order)
        {
            ValidateOrder(order);

            ExpediteOrder(order);

            AddOrderToCustomerHistory(order);
        }

        private void ValidateOrder(Order order)
        {
            // throw InvalidOrderException unless otherwise noted.

            if (order.Id != 0) 
                throw new InvalidOrderException("Order ID must be 0.");

            if ( order.TotalAmount <= 0 )
                throw new InvalidOrderException("Order Amount must be greater than 0");
            
            if ( order.Customer == null )
                throw new InvalidOrderException("Customer cannot be null");

            ValidateCustomer(order.Customer);
        }

        private void ValidateCustomer(Customer customer)
        {
            if ( customer.Id <= 0 )
                throw new InvalidCustomerException("Customer must have Id greater than 0.");

            if ( customer.HomeAddress == null )
                throw new InvalidCustomerException("Address cannot be null");

            if ( string.IsNullOrEmpty(customer.FirstName) 
                || string.IsNullOrEmpty(customer.LastName) )
                throw new InvalidCustomerException("First name or last name cannot be null or empty.");
            
            if ( customer.CreditRating <= 200 )
                throw new InsufficientCreditException("Credit must be greater than 200.");

            if ( customer.TotalPurchases < 0 )
                throw new InvalidCustomerException("Total purchases must be 0 or greater.");

            ValidateAddress(customer.HomeAddress);
        }

        private void ValidateAddress(Address homeAddress)
        {
            // throw InvalidAddressException unless otherwise noted
            if ( string.IsNullOrEmpty(homeAddress.Street1) )
                throw new InvalidAddressException("Street cannot be null or empty.");
            
            if ( string.IsNullOrEmpty(homeAddress.City) )
                throw new InvalidAddressException("City cannot be null or empty.");
            
            if ( string.IsNullOrEmpty(homeAddress.State) )
                throw new InvalidAddressException("State cannot be null or empty.");

            if ( string.IsNullOrEmpty(homeAddress.PostalCode) )
                throw new InvalidAddressException("Postal Code cannot be null or empty.");

            // TODO: country is required (not null or empty)
        }

        private void ExpediteOrder(Order order)
        {
            // TODO: if customer's total purchases > 5000 and credit rating > 500 set IsExpedited to true
        }

        private void AddOrderToCustomerHistory(Order order)
        {
            // TODO: add the order to the customer

            // TODO: update the customer's total purchases property
        }
    }
}
