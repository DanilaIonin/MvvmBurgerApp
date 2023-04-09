using MvvmBurgerApp.View;

namespace MvvmBurgerApp;

public partial class App : Application
{
    public App()
    {
        MainPage = new NavigationPage(new OrderListPage());
    }

    protected override void OnStart()
    { }

    protected override void OnSleep()
    { }

    protected override void OnResume()
    { }
}
