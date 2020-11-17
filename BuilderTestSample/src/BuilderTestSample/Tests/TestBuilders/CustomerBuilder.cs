using System;
using System.Collections.Generic;
using System.Text;
using BuilderTestSample.Model;
namespace BuilderTestSample.Tests.TestBuilders
{
    public class CustomerBuilder
    {
        private int _id;
        private Address _address;
        private string _firstName;
        private string _lastName;
        private int _creditRating;
        private decimal _totalPurchases;
        private const int TEST_ID = 176;
        public CustomerBuilder Id( int id )
        {
            _id = id;
            return this;
        }

        public CustomerBuilder Address( Address address )
        {
            _address = address;
            return this;
        }

        public CustomerBuilder FirstName( string firstName )
        {
            _firstName = firstName;
            return this;
        }

        public CustomerBuilder LastName( string lastName )
        {
            _lastName = lastName;
            return this;
        }

        public CustomerBuilder CreditRating( int creditRating )
        {
            _creditRating = creditRating;
            return this;
        }

        public CustomerBuilder TotalPurchases( decimal totalPurchases )
        {
            _totalPurchases = totalPurchases;
            return this;
        }

        public Customer Build()
        {
            return new Customer(_id)
            {
                HomeAddress = _address,
                FirstName = _firstName,
                LastName = _lastName,
                CreditRating = _creditRating,
                TotalPurchases = _totalPurchases
            };
        }

        public CustomerBuilder WithTestValues()
        {
            _id = TEST_ID;
            _firstName = "FirstTest";
            _lastName = "LastTest";
            _creditRating = 250;
            _totalPurchases = 25;

            AddressBuilder addressBuilder = new AddressBuilder();

            _address = addressBuilder
                       .WithTestValues()
                       .Build();

            return this;
        }
    }
}
