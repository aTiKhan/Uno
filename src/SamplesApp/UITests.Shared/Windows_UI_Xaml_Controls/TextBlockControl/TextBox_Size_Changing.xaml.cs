using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
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


// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Samples.Content.UITests.TextBlockControl
{
	[SampleControlInfoAttribute("TextBlockControl", "TextBox_Size_Changing", typeof(Uno.UI.Samples.Presentation.SamplePages.TextBlockViewModel))]
	public sealed partial class TextBox_Size_Changing : UserControl
	{
		public TextBox_Size_Changing()
		{
			this.InitializeComponent();
		}
	}
}
