using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Helloworld
{
	public partial class ListView : ContentPage
	{
		ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
		public ListView()
		{
			InitializeComponent();
			//EmployeeView.ItemsSource = employees;
			//employees.Add(new Employee { DisplayName = "Rob Finnerty" });
			//employees.Add(new Employee { DisplayName = "Bill Wrestler" });
			//employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
			//employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
			//employees.Add(new Employee { DisplayName = "Sheri Spruce" });
			//employees.Add(new Employee { DisplayName = "Burt Indybrick" });

			lst.ItemsSource = new List<Contacts>()
			{
				new Contacts()
				{
					Name = "Umair", Num = "0456445450945", imgsource = "http://bit.ly/2oDQpPT",
						},
						new Contacts()
				{
					Name = "Cat", Num = "034456445905", imgsource = "http://gtty.im/2psFEos",
						},
						new Contacts()
				{
					Name = "Nature", Num = "56445905", imgsource = "http://gtty.im/2psFEos",
						},
				};
		}

		private void lst_Refreshing(object sender, EventArgs e)
		{
			lst.ItemsSource = new List<Contacts>()
			{ new Contacts()
					{
					Name = "Umair", Num = "0456445450945", imgsource = "http://bit.ly/2oDQpPT",
						},
					new Contacts()
					{
					Name = "Cat", Num = "034456445905", imgsource = "http://gtty.im/2psFEos",
						},
					new Contacts() 
					{
					Name = "Umair", Num = "0456445450945", imgsource = "http://bit.ly/2oDQpPT",
						},
					new Contacts()
					{
						Name = "Cat", Num = "034456445905", imgsource = "http://gtty.im/2psFEos",
						},
					new Contacts()
					{
						Name = "Nature", Num = "56445905", imgsource = "http://gtty.im/2psFEos",
						}
			};
			lst.IsRefreshing = false;
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var value = DependencyService.Get<IDeviceInfo>().GetUniqueIdentifier();
			DisplayAlert(value, value, "OK");
		}
	}
	public interface IDeviceInfo
	{
		string GetUniqueIdentifier();
	}
	public class Employee
	{
		public string DisplayName { get; set; }
	}
	public class Contacts
	{
		public string Name
		{
			get;
			set;
		}
		public string Num
		{
			get;
			set;
		}
		public string imgsource
		{
			get;
			set;
		}
	}
}
