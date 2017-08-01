using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Helloworld
{
	public partial class DataBinding : ContentPage
	{
		ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
		public DataBinding()
		{
			InitializeComponent();
			EmployeeView.ItemsSource = employee;
			employee.Add(new Employee { DisplayName = "Rob Finnerty" });
			employee.Add(new Employee { DisplayName = "Bill Wrestler" });
			employee.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
			employee.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
			employee.Add(new Employee { DisplayName = "Sheri Spruce" });
			employee.Add(new Employee { DisplayName = "Burt Indybrick" });
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Employee;
			DisplayAlert("Hello", item.DisplayName, "OK");
		}
	}
}
