using System;

public class Circle : Shape
{
	public float r;

	public Circle(float r)
	{
		this.r = r;
	}

    public override float GetArea()
    {
		float area = 3.14f * r * r;
		return area;
    }
	public override string GetName()
	{
		return "círculo";
	}
}
