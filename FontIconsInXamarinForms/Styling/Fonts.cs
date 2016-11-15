using System;
using Xamarin.Forms;

namespace FontIconsInXamarinForms.Styling
{
	public static class Fonts
	{
		public static string FontAwesome = Device.OnPlatform("FontAwesome", "fontawesome.ttf", null);
	}
}