using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public partial class Content_Page : ContentPage
	{
		public Content_Page()
		{
			InitializeComponent();
			NavigationPage.SetBackButtonTitle(this, "");
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			
			Navigation.PushAsync(new SamplePageOne());
		}

	   	protected override void OnDisappearing()
		{
			base.OnDisappearing();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		void Handle_ClickedOne(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
