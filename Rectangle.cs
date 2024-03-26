using System;

public class Rectangle : Shape
{
	public float b;
	public float h;

	public Rectangle(float b, float h)
	{
		this.b = b;
		this.h = h;
	}

    public override float GetArea()
    {
		float area = b * h;
		return area;
    }

    public override string GetName()
    {
		return "rectángulo";
    }
}
