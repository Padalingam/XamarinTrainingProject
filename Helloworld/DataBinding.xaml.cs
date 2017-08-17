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
			var viewModel = new EmployeeViewModel();
			EmployeeView.ItemsSource = viewModel.loadData();
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Employee;
			DisplayAlert("Hello", item.DisplayName, "OK");
		}
	}

	public class EmployeeViewModel
	{
		//public ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
		public ObservableCollection<Employee> loadData()
		{
			ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
			employee.Add(new Employee { DisplayName = "Rob Finnerty" });
			employee.Add(new Employee { DisplayName = "Bill Wrestler" });
			employee.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
			employee.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
			employee.Add(new Employee { DisplayName = "Sheri Spruce" });
			employee.Add(new Employee { DisplayName = "Burt Indybrick" });
			return employee;
		}
	}
}
