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
using SQLiteNetExtensions.Attributes;

namespace DeKoelkast.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        public List<Products>? Products { get; set; }
        public Products? CurrentProducts { get; set; }
        public List<Users>? Users { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public Users? CurrentUsers { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }

        private readonly BaseRepository<Products> _productsRepository;
        private readonly BaseRepository<Users> _usersRepository;

        public MainPageViewModel()
        {
            _productsRepository = new BaseRepository<Products>();
            _usersRepository = new BaseRepository<Users>();
            Refresh();
            LoadRefresh();
        }

        private void Refresh()
        {
            Products = _productsRepository.GetEntities();
        }

        private void LoadRefresh()
        {
            Users = _usersRepository.GetEntities();
        }
    }
}
