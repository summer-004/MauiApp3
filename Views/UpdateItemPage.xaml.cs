using MauiApp3.ViewMoels;

namespace MauiApp3.Views;

public partial class UpdateItemPage : ContentPage
{
    public UpdateItemPage()
    {
        InitializeComponent();
        BindingContext = new UpdateItemViewModel();
    }
}
