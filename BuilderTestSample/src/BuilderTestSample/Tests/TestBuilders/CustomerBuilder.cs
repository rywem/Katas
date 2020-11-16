using System;
using System.Collections.Generic;
using System.Text;
using BuilderTestSample.Model;
namespace BuilderTestSample.Tests.TestBuilders
{
    public class CustomerBuilder
    {
        private Customer _customer;

        public CustomerBuilder Id(int id)
        {
            _customer = new Customer(id); ;
            return this;
        }

        public Customer Build()
        {
            return _customer;
        }
    }
}
