using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Helloworld
{
	public partial class Master_Page : MasterDetailPage
	{
		public Master_Page()
		{
			InitializeComponent();
			//Detail = new NavigationPage(new AbsolutePage());
			IsPresented = true;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new AbsolutePage());
			IsPresented = false;
		}
		void Handle_Clicked1(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new RelativeLayout());
			IsPresented = false;
		}
}
}
