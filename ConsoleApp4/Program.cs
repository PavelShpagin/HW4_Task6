
using System.Text;
using System.Xml.Linq;

abstract class GeographicalObject
{
	protected double x;
	protected double y;
	protected string name;
	protected string description;

	public virtual string GetInfo()
	{
		return $"Назва: {name}\nКоординати: X={x}, Y={y}\nОпис: {description}";
	}
}

class River : GeographicalObject
{
	private double _flowSpeed;
	private double _length;
	public override string GetInfo()
	{
		return base.GetInfo() + $"\nШвидкість течії: {_flowSpeed} см/с\nЗагальна довжина: {_length} км";
	}
}

class Mountain : GeographicalObject
{
	private double _highestPoint;
	public override string GetInfo()
	{
		return base.GetInfo() + $"\nНайвища точка: {_highestPoint} м";
	}
}