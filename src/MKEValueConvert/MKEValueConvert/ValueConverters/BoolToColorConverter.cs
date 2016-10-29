using System;
using System.Globalization;
using Xamarin.Forms;
namespace MKEValueConvert
{
	public class BoolToColorConverter : IValueConverter
	{
		public BoolToColorConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null || value.GetType() != typeof(bool))
				return Color.Gray;

			return (bool)value ? Color.Green : Color.Gray;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
