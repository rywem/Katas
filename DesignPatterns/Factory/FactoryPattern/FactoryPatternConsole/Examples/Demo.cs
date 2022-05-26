using System;
namespace FactoryPatternConsole.Examples
{
	public class Demo
	{
		public void Run()
        {
			var factory = new TrackingThemeFactory();
			var theme1 = factory.CreateTheme(false);
			var theme2 = factory.CreateTheme(true);

			Console.WriteLine(factory.Info);
        }
	}
}

