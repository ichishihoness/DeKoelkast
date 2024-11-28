using DeKoelkast.Repositories;

namespace DeKoelkast
{
    public partial class App : Application
    {
        public static UserRepository? UserRepository { get; private set; }
        public App(UserRepository userRepository)
        {
            InitializeComponent();

            UserRepository = userRepository;
            MainPage = new AppShell();
        }
    }
}
