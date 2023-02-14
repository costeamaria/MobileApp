using MobileApp;
using MobileApp.Models;

namespace MobileApp;

public partial class EntryProduct : ContentPage
{
    public EntryProduct()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetBakeryShopsAsync();
    }
    async void OnBakeryShopAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new BakeryShop()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as BakeryShop
            });
        }
    }
}