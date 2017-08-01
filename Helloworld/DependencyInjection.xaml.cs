using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public interface IDeviceInfo
	{
		string GetUniqueIdentifier();
	}
	public partial class DependencyInjection : ContentPage
	{
		public DependencyInjection()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
			//var value = DependencyService.Get<IDeviceInfo>().GetUniqueIdentifier();
			//DisplayAlert("Simple Alert", value, "OK");
		}
	}
}
