using BuilderTestSample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTestSample.Tests.TestBuilders
{
    public class AddressBuilder
    {
        private Address _address = new Address();

        public Address Build()
        {
            return _address;
        }

        public AddressBuilder Street1( string street1 )
        {
            _address.Street1 = street1;
            return this;
        }

        public AddressBuilder City( string city )
        {
            _address.City = city;
            return this;
        }

        public AddressBuilder State( string state )
        {
            _address.State = state;
            return this;
        }

        public AddressBuilder WithTestValues()
        {
            _address.Street1 = "123 Apple St.";
            _address.City = "New York City";
            _address.State = "NY";
            return this;
        }
    }
}
