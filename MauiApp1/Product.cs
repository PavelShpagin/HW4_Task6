using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MauiApp1
{
	public class Product
	{
		public double Price { get; set; }
		public string Name { get; set; }
		public string CountryOfOrigin { get; set; }
		public DateTime PackagingDate { get; set; }
		public string Description { get; set; }
		public Product(double price, string name) 
		{ 
			Price = price; 
			Name = name;
		}
		public virtual string GetInfo() 
		{ 
			return $"{Name} - ${Price}"; 
		}
	}
}
