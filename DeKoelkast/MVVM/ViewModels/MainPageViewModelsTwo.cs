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
    public class MainPageViewModelTwo
    {
        public List<Users>? Users { get; set; }
        public Users? CurrentUsers { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }

        private readonly BaseRepository<Users> _baseRepository;

        public MainPageViewModelTwo()
        {
            _baseRepository = new BaseRepository<Users>();
            Refresh();
        }
        private void Refresh()
        {
            Users = _baseRepository.GetEntities();
        }
    }
}
