using Microsoft.Maui.Controls;

namespace FoodOrderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Добавление товара в корзину
        private void OnAddItemClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            string itemName = button.Text.Replace("Добавить ", "");
            // Логика добавления товара в локальное хранилище
            Preferences.Set(itemName, Preferences.Get(itemName, 0) + 1);
        }

        // Переход к странице корзины
        private async void OnGoToCartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartPage());
        }
    }
}