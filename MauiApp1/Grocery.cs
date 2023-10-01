using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
	public class Grocery : Product
	{
		public DateTime ExpirationDate { get; set; }
		public int Quantity { get; set; }
		public string UnitOfMeasure { get; set; }
		public Grocery(double price, string name, DateTime expirationDate, int quantity, string unitOfMeasure) : base(price, name)
		{
			ExpirationDate = expirationDate;
			Quantity = quantity;
			UnitOfMeasure = unitOfMeasure;
		}
		public override string GetInfo()
		{
			return "Grocery: \n" + base.GetInfo() + $"\nInfo:\nExpiration Date: {ExpirationDate}\nQuantity: {Quantity}\nUnitOfMeasure: {UnitOfMeasure}";
		}
	}
}