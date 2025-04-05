using Microsoft.Maui.Controls;

namespace FoodOrderApp;

public partial class CartPage : ContentPage
{
    public CartPage()
    {
        InitializeComponent();

        var cartItems = new List<CartItem>();

        // ��������� ������ �� ���������� ���������
        foreach (var item in new[] { "����� 1", "����� 2", "����� 3", "����� 4" })
        {
            int quantity = Preferences.Get(item, 0);
            if (quantity > 0)
            {
                cartItems.Add(new CartItem
                {
                    Name = item,
                    Quantity = quantity,
                    Price = 100, // ��������� ���� ������
                    Total = 100 * quantity
                });
            }
        }

        CartListView.ItemsSource = cartItems;
    }

    private async void OnPlaceOrderClicked(object sender, EventArgs e)
    {
        // ������ ���������� ������
        await DisplayAlert("�����", "��� ����� ��������!", "OK");
        await Navigation.PushAsync(new ProfilePage());
    }
}

public class CartItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
}
