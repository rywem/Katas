using Xunit;
using FactoryPatternConsole.Examples;
namespace FactoryPatternTests.Examples
{
	public class TrackingThemeFactoryTests
	{
		[Fact]
		public void AssertFactoryReturnsDarkTheme()
        {
			var factory = new TrackingThemeFactory();
			var theme = factory.CreateTheme(true);
			var bgColor = "dark gray";
			var textColor = "white";
			Assert.Equal(bgColor, theme.BackgroundColor);
			Assert.Equal(textColor, theme.TextColor);
        }

		[Fact]
		public void AssertFactoryReturnsLightTheme()
		{
			var factory = new TrackingThemeFactory();
			var theme = factory.CreateTheme(false);
			var bgColor = "white";
			var textColor = "black";
			Assert.Equal(bgColor, theme.BackgroundColor);
			Assert.Equal(textColor, theme.TextColor);
		}
	}
}

