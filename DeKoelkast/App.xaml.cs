﻿namespace DeKoelkast
{
    public partial class App : Application
    {
        public static UserRepository? UserRepo { get; private set; }
        public App(UserRepository userRepo)
        {
            InitializeComponent();

            UserRepo = userRepo;
            MainPage = new AppShell();
        }
    }
}
