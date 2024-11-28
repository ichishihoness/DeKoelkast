using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PropertyChanged;
using Bogus;
using DeKoelkast.MVVM.Models;

namespace DeKoelkast.MVVM.ViewModels
{

	[AddINotifyPropertyChangedInterface]
	public class MainPageViewModel
	{
		public List<Users>? Users { get; set; }
		public Users? CurrentUser { get; set; }
		public ICommand? AddOrUpdateCommand { get; set; }
		public ICommand? DeleteCommand { get; set; }

		public MainPageViewModel()
		{
			Refresh();
			GenerateNewUser();
			AddOrUpdateCommand = new Command(async () =>
			{
				App.UserRepository.AddOrUpdate(CurrentUser);
				Console.WriteLine(App.UserRepository.statusMessage);
				GenerateNewUser();
				Refresh();
			});
			DeleteCommand = new Command(() =>
			{
				App.UserRepository.Delete(CurrentUser.Id);
				Refresh();
				GenerateNewUser();
			});
		}

		private void GenerateNewUser()
		{
			CurrentUser = new Faker<Users>()
				.RuleFor(x => x.Username, f => f.Person.UserName)
				.Generate();
		}	

		private void Refresh()
		{
			Users = App.UserRepository.GetAll();
		}
	}
}