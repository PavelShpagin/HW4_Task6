using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
	public class Book : Product
	{
		public int PageCount { get; set; }
		public string Publisher { get; set; }
		public List<string> Authors { get; set; }
		public Book(double price, string name, int pageCount, string publisher, List<string> authors) : base(price, name)
		{
			PageCount = pageCount;
			Publisher = publisher;
			Authors = authors;
		}
		public override string GetInfo()
		{
			string allAuthors = "";
			for (int i = 0; i < Authors.Count; i++) 
			{
				allAuthors += Authors[i] + "\n";
			}
			return "Book: \n" + base.GetInfo() + $"\nInfo:\nPage count: {PageCount}\nPublisher: {Publisher}\nAuthors: {allAuthors}";
		}
	}
}
