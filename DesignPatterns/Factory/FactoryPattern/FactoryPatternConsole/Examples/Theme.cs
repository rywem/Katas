using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternConsole.Examples
{
    public interface ITheme
    {
        string TextColor { get; }
        string BackgroundColor { get; }
    }

    class LightTheme : ITheme
    {
        public string TextColor => "black";
        public string BackgroundColor => "white";
    }

    class DarkTheme : ITheme
    {
        public string TextColor => "white";
        public string BackgroundColor => "dark gray";
    }
}
