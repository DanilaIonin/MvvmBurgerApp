using MvvmBurgerApp.ViewModels;

namespace MvvmBurgerApp.View;

public partial class OrderPage : ContentPage
{
	public BurgerViewModel ViewModel { get; set; }
	public OrderPage(BurgerViewModel vm)
	{
		InitializeComponent();
		ViewModel= vm;
		this.BindingContext = ViewModel;
	}
}