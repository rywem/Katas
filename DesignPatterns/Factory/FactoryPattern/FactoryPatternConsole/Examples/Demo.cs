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

			// bulk replacement

			var factory2 = new ReplaceableThemeFactory();
			var magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BackgroundColor);

			factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BackgroundColor);
        }
	}
}

