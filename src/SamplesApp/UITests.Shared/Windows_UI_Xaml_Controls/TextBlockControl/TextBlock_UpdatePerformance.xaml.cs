using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using System.Threading.Tasks;

#if NETFX_CORE
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#elif XAMARIN
using Windows.UI.Xaml.Controls;
using System.Globalization;
#endif

namespace Uno.UI.Samples.Content.UITests.TextBlockControl
{
	[SampleControlInfoAttribute("TextBlockControl", "TextBlock_UpdatePerformance", typeof(nVentive.Umbrella.Presentation.Light.ViewModelBase))]
	public sealed partial class TextBlock_UpdatePerformance : UserControl
	{
		public TextBlock_UpdatePerformance()
		{
			this.InitializeComponent();

			text1Button.Click += async delegate
			{
				for (int i = 0; i < 1000; i++)
				{
					text1.Text = i.ToString();
					await Task.Yield();
				}
			};
		}
	}
}
