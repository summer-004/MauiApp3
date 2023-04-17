using MauiApp3.ViewMoels;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {

        ItemsViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new ItemsViewModel();
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
