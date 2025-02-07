namespace Visitka.Presentation
{
    using Microsoft.Maui.Controls;
    using Visitka.Presentation.Pages;
    using Visitka.Presentation.ViewModels;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}