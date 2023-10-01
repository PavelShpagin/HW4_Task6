using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<ProductViewModel> Products { get; }

		public MainPage()
		{
			InitializeComponent();

			Products = new ObservableCollection<ProductViewModel>
			{
				new ProductViewModel(new Book(8, "The Traitor's Son", 300, "John Doe", new List<string>(new string[] { "John Doe" }))),
				new ProductViewModel(new Grocery(12, "Apples", DateTime.Today.AddDays(7), 5, "lbs")),
            };

			ProductsCollectionView.ItemsSource = Products;
		}

		private async void AddProductButton_Clicked(object sender, EventArgs e)
		{
			string selectedType = await DisplayActionSheet("Select Product Type", "Cancel", null, "Book", "Grocery");

			if (selectedType == "Book")
			{
				string productName = ProductNameEntry.Text;
				double productPrice;

				if (!double.TryParse(ProductPriceEntry.Text, out productPrice))
				{
					await DisplayAlert("Error", "Invalid price input", "OK");
					return;
				}

				int pageCount;
				string author;

				var pageInput = await DisplayPromptAsync("Book Details", "Enter number of pages:");
				if (!int.TryParse(pageInput, out pageCount))
				{
					await DisplayAlert("Error", "Invalid page count input", "OK");
					return;
				}

				author = await DisplayPromptAsync("Book Details", "Enter author:");

				var book = new Book(productPrice, productName, pageCount, author, new List<string>(new string[] { author }));
				Products.Add(new ProductViewModel(book));
			}
			else if (selectedType == "Grocery")
			{
				string productName = ProductNameEntry.Text;
				double productPrice;

				if (!double.TryParse(ProductPriceEntry.Text, out productPrice))
				{
					await DisplayAlert("Error", "Invalid price input", "OK");
					return;
				}

				DateTime expirationDate;
				int quantity;

				var dateInput = await DisplayPromptAsync("Grocery Details", "Enter expiration date (yyyy-MM-dd):");
				if (!DateTime.TryParse(dateInput, out expirationDate))
				{
					await DisplayAlert("Error", "Invalid expiration date input", "OK");
					return;
				}

				var quantityInput = await DisplayPromptAsync("Grocery Details", "Enter quantity:");
				if (!int.TryParse(quantityInput, out quantity))
				{
					await DisplayAlert("Error", "Invalid quantity input", "OK");
					return;
				}

				var grocery = new Grocery(productPrice, productName, expirationDate, quantity, "units");
				Products.Add(new ProductViewModel(grocery));
			}
		}

		private void RemoveProductButton_Clicked(object sender, EventArgs e)
		{
			if (Products.Any())
			{
				var lastProduct = Products.Last();
				Products.Remove(lastProduct);
			}
		}
	}

}