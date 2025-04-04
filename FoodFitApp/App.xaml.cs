using Microsoft.Maui.Controls;
using FoodFitApp.Views;
namespace FoodFitApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Navigation(new SignUpPage());
        }
    }
}
