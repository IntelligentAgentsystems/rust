﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace OrderClient.Features.Ordering
{
	public class NewOrderView : UserControl
	{
		public NewOrderView()
		{
			this.InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
