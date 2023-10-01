using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
	public class ProductViewModel : BindableObject
	{
		/*
		private string imageUrl;
		public string ImageUrl
		{
			get { return imageUrl; }
			set
			{
				imageUrl = value;
				OnPropertyChanged(nameof(ImageUrl));
			}
		}*/


		public Product MyProduct;
		public string Name => MyProduct.Name;
		public double Price => MyProduct.Price;

		public string DisplayText => MyProduct.GetInfo();

		//public Command BuyCommand { get; }

		public ProductViewModel(Product product)
		{
			//ButtonText = "Buy";
			//ImageUrl = imageUrl;
			this.MyProduct = product;
			//BuyCommand = new Command(OnBuy);
		}

		//private void OnBuy()
		//{
		//}
	}
}
