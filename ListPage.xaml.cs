using MobileApp.Models;
using MobileApp;


namespace MobileApp;


public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var productS = (BakeryShop)BindingContext;

        listView.ItemsSource = await App.Database.GetListProductsAsync(productS.ID);
    }

    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage((BakeryShop)
       this.BindingContext)
        {
            BindingContext = new Product()
        });

    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (BakeryShop)BindingContext;
        await App.Database.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (BakeryShop)BindingContext;
        await App.Database.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
    }
}