using System;

public class Square : Shape
{
	public float l;

	public Square(float l)
	{
		this.l = l;
	}

	public override float GetArea()
	{
		float area = l * l;
		return area;
	}
	public override string GetName()
	{
		return "cuadrado";
	}

}
