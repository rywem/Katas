using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.Ardalis.NSFileLogger
{
    public interface IFileNameStrategy
    {
        string GetFileName(DateTime currentTime);
    }
}
