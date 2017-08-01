using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public partial class AnimationPage : ContentPage
	{
		public AnimationPage()
		{
			InitializeComponent();
			Padding = new Thickness(0, 10, 0, 0);
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//nalashaaLogo.RotateTo(90, 2000);
			//nalashaaLogo.ScaleTo(2, 2000);
			//nalashaaLogo.TranslateTo(10, 10, 1000);
			//nalashaaLogo.Opacity = 0;
			//nalashaaLogo.FadeTo(1, 4000);
			nalashaaLogo.TranslateTo(0, 200, 2000, Easing.BounceIn);
		}
	}
}
