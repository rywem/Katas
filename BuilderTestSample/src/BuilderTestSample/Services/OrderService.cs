﻿using BuilderTestSample.Exceptions;
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
            // throw InvalidCustomerException unless otherwise noted
            if ( customer.Id <= 0 )
                throw new InvalidCustomerException("Customer must have Id greater than 0.");

            if ( customer.HomeAddress == null )
                throw new InvalidCustomerException("Address cannot be null");

            if ( string.IsNullOrEmpty(customer.FirstName) || string.IsNullOrEmpty(customer.LastName) )
                throw new InvalidCustomerException("First name or last name cannot be null or empty.");
            // TODO: customer must have credit rating > 200 (otherwise throw InsufficientCreditException)
            // TODO: customer must have total purchases >= 0

            ValidateAddress(customer.HomeAddress);
        }

        private void ValidateAddress(Address homeAddress)
        {
            // throw InvalidAddressException unless otherwise noted
            // create an AddressBuilder to implement the tests for these scenarios

            // TODO: street1 is required (not null or empty)
            // TODO: city is required (not null or empty)
            // TODO: state is required (not null or empty)
            // TODO: postalcode is required (not null or empty)
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
