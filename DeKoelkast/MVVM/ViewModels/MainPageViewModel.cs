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
using DeKoelkast.Repositories;

namespace DeKoelkast.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        public List<Users>? Users { get; set; }
        public Users? CurrentUser { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }

        private readonly BaseRepository<Users> _userRepository;

        public MainPageViewModel()
        {
            _userRepository = new BaseRepository<Users>();
            Refresh();
            GenerateNewUser();
            AddOrUpdateCommand = new Command(async () =>
            {
                _userRepository.SaveEntity(CurrentUser);
                Console.WriteLine("User saved successfully.");
                GenerateNewUser();
                Refresh();
            });
            DeleteCommand = new Command(() =>
            {
                _userRepository.DeleteEntity(CurrentUser);
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
            Users = _userRepository.GetEntities();
        }
    }
}
