using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Muresan_Roberta_Andreea_Lab12.Services;
using Muresan_Roberta_Andreea_Lab12.Views;

namespace Muresan_Roberta_Andreea_Lab12
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
