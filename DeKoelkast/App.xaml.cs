using DeKoelkast.MVVM.Models;
using DeKoelkast.Repositories;

namespace DeKoelkast
{
    public partial class App : Application
    {
        public static BaseRepository<Users>? UserRepository { get; private set; }
        public static BaseRepository<Products>? ProductRepository { get; private set; }
        public App(BaseRepository<Users>? userRepository, BaseRepository<Products>? productRepository)
        {
            InitializeComponent();

            UserRepository = userRepository;
            ProductRepository = productRepository;
            MainPage = new AppShell();
        }
    }
}
