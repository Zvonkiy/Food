using Microsoft.Maui.Controls;

namespace FoodOrderApp;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();

        // Считываем заказ из локального хранилища
        var orders = new List<Order>
        {
            new Order { OrderNumber = 1, Date = DateTime.Now, Status = "Новый" }
        };

        OrdersListView.ItemsSource = orders;
    }
}

public class Order
{
    public int OrderNumber { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
}
