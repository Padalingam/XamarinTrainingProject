using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public partial class Gestures : ContentPage
	{
		public Gestures()
		{
			InitializeComponent();
		}
		void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			DisplayAlert("Recognized", "Yes", "OK");
		}
	}
}
