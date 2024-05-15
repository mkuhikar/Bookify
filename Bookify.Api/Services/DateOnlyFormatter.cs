using System.Text.Json;
namespace Bookify.Api.Services
{
	public class DateOnlyFormatter
	{
		public object Convert(object input, Type targetType, object context)
		{
			if (input is string dateString)
			{
				return DateOnly.Parse(dateString);
			}
			return null;
		}

		public object ConvertBack(object value, Type targetType, object context)
		{
			throw new NotImplementedException();
		}
	}
}
