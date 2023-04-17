using MauiApp3.Views;

namespace MauiApp3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(UpdateItemPage), typeof(UpdateItemPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
    }
}
