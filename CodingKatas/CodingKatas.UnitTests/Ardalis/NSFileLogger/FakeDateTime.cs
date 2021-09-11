using CodingKatas.Ardalis.NSFileLogger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.UnitTests.Ardalis.NSFileLogger
{
    public class FakeDateTime : IDateTime
    {
        public DateTime Now { get; set; } = DateTime.Now;
    }
}
