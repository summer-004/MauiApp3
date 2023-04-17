using MauiApp3.ViewMoels;

namespace MauiApp3.Views;

public partial class ItemDetailPage : ContentPage
{
	public ItemDetailPage()
	{
		InitializeComponent();
        BindingContext = new ItemDetailViewModel();
    }
}
