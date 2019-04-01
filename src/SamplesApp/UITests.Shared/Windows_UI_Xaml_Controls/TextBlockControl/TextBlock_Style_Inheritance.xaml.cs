using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Threading;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Reactive.Linq;
using nVentive.Umbrella.Presentation;
using nVentive.Umbrella.Extensions;
using Uno.Extensions;
using System.Reactive.Concurrency;
using Windows.UI.Xaml.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using System.Globalization;
using Uno.UI.Samples.Controls;

#if NETFX_CORE
using System.Runtime.InteropServices.WindowsRuntime;
#elif XAMARIN
#endif

namespace Uno.UI.Samples.Content.UITests.TextBlockControl
{
	[SampleControlInfoAttribute("TextBlockControl", "TextBlock_Style_Inheritance", typeof(nVentive.Umbrella.Presentation.Light.ViewModelBase))]
	public sealed partial class TextBlock_Style_Inheritance : UserControl
	{
		public TextBlock_Style_Inheritance()
		{
			this.InitializeComponent();
		}
	}
}
