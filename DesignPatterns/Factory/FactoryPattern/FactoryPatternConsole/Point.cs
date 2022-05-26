using System;
namespace FactoryPatternConsole
{
	public class Point
	{
		private double x, y;
		internal Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

        public override string ToString()
        {
			return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
    }
}

