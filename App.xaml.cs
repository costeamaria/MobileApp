using System;
using MobileApp.Data;
using System.IO;
using MobileApp;

namespace MobileApp;
 public partial class App : Application
{
    static BakeryShopDatabase database;
    public static BakeryShopDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new BakeryShopDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
