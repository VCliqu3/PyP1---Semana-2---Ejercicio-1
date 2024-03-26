using System;

public class Triangle : Shape
{
	public float b;
	public float h;

	public Triangle(float b, float h)
	{
		this.b = b;
		this.h = h;
	}

    public override float GetArea()
    {
		float area = b * h / 2;
		return area;
    }
	public override string GetName()
	{
		return "triángulo";
	}
}
