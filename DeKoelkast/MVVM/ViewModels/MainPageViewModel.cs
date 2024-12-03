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
        public List<Products>? Products { get; set; }
        public Products? CurrentProducts { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }

        private readonly BaseRepository<Products> _baseRepository;

        public MainPageViewModel()
        {
            _baseRepository = new BaseRepository<Products>();
            Refresh();
        }
        private void Refresh()
        {
            Products = _baseRepository.GetEntities();
        }
    }
}
