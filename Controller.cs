using System;

public class Controller
{
	public void Execute()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Shape shape = null;

            bool validFigureOption = false;

            while (!validFigureOption)
            {
                Console.WriteLine("Introduce el número de la figura que quieres calcular el área");
                Console.WriteLine("1.- Cuadrado");
                Console.WriteLine("2.- Rectángulo");
                Console.WriteLine("3.- Triángulo");
                Console.WriteLine("4.- Círculo");

                string shapeOption = Console.ReadLine();

                switch (shapeOption)
                {
                    case "1":
                        shape = GetSquare();
                        validFigureOption = true;
                        break;
                    case "2":
                        shape = GetRectangle();
                        validFigureOption = true;

                        break;
                    case "3":
                        shape = GetTriangle();
                        validFigureOption = true;

                        break;
                    case "4":
                        shape = GetCircle();
                        validFigureOption = true;
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida");
                        break;
                }
            }

            
            float area = shape.GetArea();
            Console.WriteLine($"El área del {shape.GetName()} es {area}");

            /////////////////////////////////////////////////////////////////////////////////////////////

            bool validContinueOption = false;

            while (!validContinueOption)
            {
                Console.WriteLine("Deseas calcular el área de otra figura? (Y/N)");
                string continueOption = Console.ReadLine();

                switch (continueOption)
                {
                    case "Y":
                    case "y":
                        validContinueOption = true;
                        break;
                    case "N":
                    case "n":
                        continueProgram = false;
                        validContinueOption = true;
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida");
                        break;
                }
            }
        }
    }

    private Square GetSquare()
    {
        Console.WriteLine("Ha seleccionado un cuadrado");
        Console.WriteLine("Digite el lado del cuadrado");
        float l = float.Parse(Console.ReadLine());
        return new Square(l);
    }

    private Rectangle GetRectangle()
    {
        Console.WriteLine("Ha seleccionado un rectángulo");
        Console.WriteLine("Digite la base del rectángulo");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite la altura del rectángulo");
        float h = float.Parse(Console.ReadLine());
        return new Rectangle(b, h);
    }

    private Triangle GetTriangle()
    {
        Console.WriteLine("Ha seleccionado un triángulo");
        Console.WriteLine("Digite la base del triángulo");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite la altura del triángulo");
        float h = float.Parse(Console.ReadLine());
        return new Triangle(b, h);
    }

    private Circle GetCircle()
    {
        Console.WriteLine("Ha seleccionado un círculo");
        Console.WriteLine("Digite el radio del circulo");
        float r = float.Parse(Console.ReadLine());
        return new Circle(r);
    }
}

