using System;
using System.Collections.Generic;
using System.Text;
using BuilderTestSample.Model;
namespace BuilderTestSample.Tests.TestBuilders
{
    public class CustomerBuilder
    {
        private int _Id;
        private Address _Address;
        private string _FirstName;
        private string _LastName;
        private const int TEST_ID = 176;
        public CustomerBuilder Id(int id)
        {
            _Id = id;
            return this;
        }

        public CustomerBuilder Address( Address address )
        {
            _Address = address;
            return this;
        }

        public CustomerBuilder FirstName( string firstName )
        {
            _FirstName = firstName;
            return this;
        }

        public CustomerBuilder LastName( string lastName )
        {
            _LastName = lastName;
            return this;
        }

        public Customer Build()
        {
            return new Customer(_Id)
            {
                HomeAddress = _Address
            };
        }

        public CustomerBuilder WithTestValues()
        {
            _Id = TEST_ID;
            _Address = new Address();
            _FirstName = "FirstTest";
            _LastName = "LastTest";
            return this;
        }
    }
}
