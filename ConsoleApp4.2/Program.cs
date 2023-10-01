
using System.Text;

interface IGeographicObject
{
	string GetInfo();
}

class River : IGeographicObject
{
	private double _x;
	private double _y;
	private string _name;
	private string _description;
	private double _flowSpeed;
	private double _length;

	public River(double x, double y, string name, string description, double flowSpeed, double length)
	{
		_x = x;
		_y = y;
		_name = name;
		_description = description;
		_flowSpeed = flowSpeed;
		_length = length;
	}

	public string GetInfo()
	{
		return $"Назва: {_name}\nКоординати: X={_x}, Y={_y}\nОпис: {_description}\nШвидкість течії: {_flowSpeed} см/с\nЗагальна довжина: {_length} км";
	}
}

class Mountain : IGeographicObject
{
	private double _x;
	private double _y;
	private string _name;
	private string _description;
	private double _highestPoint;

	public Mountain(double x, double y, string name, string description, double highestPoint)
	{
		_x = x;
		_y = y;
		_name = name;
		_description = description;
		_highestPoint = highestPoint;
	}

	public string GetInfo()
	{
		return $"Назва: {_name}\nКоординати: X={_x}, Y={_y}\nОпис: {_description}\nНайвища точка: {_highestPoint} метрів";
	}
}
class Program
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = Encoding.UTF8;

		IGeographicObject river = new River(48.756, 30.523, "Дніпро", "Найбільша річка України", 100, 2200);
		IGeographicObject mountain = new Mountain(27.175, 86.866, "Еверест", "Найвища гора у світі", 8848);

		Console.WriteLine("Інформація про річку:");
		Console.WriteLine(river.GetInfo());

		Console.WriteLine("\nІнформація про гору:");
		Console.WriteLine(mountain.GetInfo());

		Console.ReadKey();
	}
}