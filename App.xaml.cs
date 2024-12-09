using Microsoft.Maui.Controls;
using toDoList.MVVM.Vista;

namespace toDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new VistaPrincipal());
        }
    }
}

