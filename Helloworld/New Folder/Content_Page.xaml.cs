using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Auth;
using Xamarin.Forms;

namespace Helloworld
{
	public partial class Content_Page : ContentPage
	{
		public string UserName
		{
			get
			{
				var account = AccountStore.Create().FindAccountsForService("Helloworld").FirstOrDefault();
				return (account != null) ? account.Username : null;
			}
		}

		public string Password
		{
			get
			{
				var account = AccountStore.Create().FindAccountsForService("Helloworld").FirstOrDefault();
				return (account != null) ? account.Properties["Password"] : null;
			}
		}

		public Content_Page()
		{
			InitializeComponent();
			NavigationPage.SetBackButtonTitle(this, "");
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			SaveCredentials("Mani", "Hello");
			System.Diagnostics.Debug.WriteLine("Username is {0} and password is {1}", UserName, Password);
			//Navigation.PushAsync(new SamplePageOne());
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

		}

		public void SaveCredentials(string userName, string password)
		{
			if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
			{
				Account account = new Account
				{
					Username = userName
				};
				account.Properties.Add("Password", password);
				AccountStore.Create().Save(account, "Helloworld");
			}
		}
	}
}
