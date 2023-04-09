using MvvmBurgerApp.Models;
using MvvmBurgerApp.ViewModels;

namespace MvvmBurgerApp.View;

public partial class OrderListPage : ContentPage
{
	
	public OrderListPage()
	{
		InitializeComponent();
		BindingContext = new BurgerListViewModel() { Navigation = this.Navigation };

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		List<BurgerViewModel> burgers= new List<BurgerViewModel>();
		foreach (var b in booksList.ItemsSource) burgers.Add((BurgerViewModel)b);

		int totalPrice = 0;
		foreach (var b in burgers) totalPrice += b.Total;
		TotalPrice.Text = totalPrice.ToString();
    }
}