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
		public Product MyProduct;
		public string DisplayText => MyProduct.GetInfo();
		public ProductViewModel(Product product)
		{
			this.MyProduct = product;
		}
	}
}
