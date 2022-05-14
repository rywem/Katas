using System;
namespace FactoryPatternConsole
{
	public class Point
	{
		// Factory method
		public static Point NewCartesianPoint(double x, double y)
        {
			return new Point(x, y);
        }
		private double x, y;
		private Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}
	}
}

