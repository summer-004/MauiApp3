using MauiApp3.Models;
using MauiApp3.ViewMoels;

namespace MauiApp3.Views;

public partial class NewItemPage : ContentPage
{
    public Item Item { get; set; }

    public NewItemPage()
    {
        InitializeComponent();
        BindingContext = new NewItemViewModel();
    }
}
