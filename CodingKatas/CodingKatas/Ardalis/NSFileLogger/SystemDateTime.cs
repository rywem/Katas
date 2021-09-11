using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.Ardalis.NSFileLogger
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
