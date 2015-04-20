﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Win10Demo
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class RelativePanelView : Page
	{
		public RelativePanelView()
		{
			this.InitializeComponent();
		}

		private void AlignTop_Click(object sender, RoutedEventArgs e)
		{
			RelativePanel.SetAlignTopWith(WhiteRect, "BlueRect");
			RelativePanel.SetAlignTopWith(RedRect, "BlueRect");
			//RelativePanel.SetAlignLeftWith(Panel, RedButton);
        }
		private void AlignBottom_Click(object sender, RoutedEventArgs e)
		{
			//RelativePanel.SetAlignBottomWith(WhiteButton, "BlueButton");
			//RelativePanel.SetAlignBottomWith(RedButton, "BlueButton");
		}
	}
}
