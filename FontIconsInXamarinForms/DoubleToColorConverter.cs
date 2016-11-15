using System;
namespace FontIconsInXamarinForms
{
	public class DoubleToColorConverter : Xamarin.Forms.IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			var num = (double)value;
			return new Xamarin.Forms.Color((num - 1.0) * -1.0, 1.0 - num, num);
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}