using FactoryPatternConsole.Examples;
using Xunit;
namespace FactoryPatternTests.Examples
{
	public class ReplaceableThemeFactoryTests
	{
		[Fact]
		public void ReplaceDarkWithLight()
        {
			var factory = new ReplaceableThemeFactory();
			
			var magicTheme = factory.CreateTheme(true);
			var firstBG = "dark gray";
			Assert.Equal(firstBG, magicTheme.Value.BackgroundColor);
			// Perform replacement
			factory.ReplaceTheme(false);
			var secondBG = "white";
			Assert.Equal(secondBG, magicTheme.Value.BackgroundColor);
		}
	}
}

