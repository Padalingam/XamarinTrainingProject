using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await MainProgressBar.ProgressTo(0.8, 1000, Easing.Linear);
		}
	}
}
