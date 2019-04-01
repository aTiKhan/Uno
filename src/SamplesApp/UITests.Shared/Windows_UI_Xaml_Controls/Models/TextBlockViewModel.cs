using System;
using System.Globalization;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno.UI.Samples.UITests.Helpers;
using Windows.UI.Core;

namespace Uno.UI.Samples.Presentation.SamplePages
{
	public class TextBlockViewModel : ViewModelBase
	{
		public TextBlockViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public string CurrentDate { get; private set; }
		public long IncreasingSize { get; private set; }
		public string IncreasingText { get; private set; }
		public string AlternatingLongText { get; private set; }
		public string AlternatingSmallText { get; private set; }
		public TimeSpan RandomTimeSpan { get; private set; } = TimeSpan.FromMinutes(123);

		private async void ObserveAlternatingLongText()
		{
			long i = 0;
			while(!CT.IsCancellationRequested)
			{
				await Task.Delay(TimeSpan.FromSeconds(1));
				i++;
				var alternate = i % 2 == 0;

				AlternatingLongText = alternate
					? ""
					: "This is a very long line of text that should wrap properly";

				AlternatingSmallText = alternate
					? ""
					: "Small text";

				IncreasingText = "This is a very long databound text with a number {0}".InvariantCultureFormat((i * 10) % 200);

				IncreasingSize = (i * 10) % 200;

				CurrentDate = DateTimeOffset.Now.ToString(CultureInfo.InvariantCulture);

			}
		}
	}
}
