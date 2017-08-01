using System;

using Xamarin.Forms;

namespace Helloworld
{
	public class AbsoluteLayoutPage : ContentPage
	{
		public AbsoluteLayoutPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

