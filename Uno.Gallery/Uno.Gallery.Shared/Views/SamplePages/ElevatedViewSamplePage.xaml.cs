﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

namespace Uno.Gallery.Views.Samples
{
	[SamplePage(SampleCategory.UIComponents, "ElevatedView", Description = Description, DocumentationLink = "https://platform.uno/docs/articles/features/ElevatedView.html")]
	public sealed partial class ElevatedViewSamplePage : Page
	{
		private const string Description = "ElevatedView component allow to highlight the different levels of layout";

		public ElevatedViewSamplePage()
		{
			this.InitializeComponent();
		}
	}
}
