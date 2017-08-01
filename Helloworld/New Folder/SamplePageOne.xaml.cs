using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public partial class SamplePageOne : ContentPage
	{
		public SamplePageOne()
		{
			InitializeComponent();
			//NavigationPage.SetBackButtonTitle(this, "");
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SamplePageTwo());
		}
	}
}
