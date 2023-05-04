using System;
using System.Numerics;
using Klasser;

class Program
{
	static void Main(string[] args)
	{
		Shape[] shapes = new Shape[20];
		float totalArea = 0;

		
		for (int i = 0; i < shapes.Length; i++)
		{
			shapes[i] = Shape.GenerateShape();
			totalArea += shapes[i].Area;
		}

		
		float averageArea = totalArea / shapes.Length;

		
		Console.WriteLine("Figurer:");
		foreach (Shape shape in shapes)
		{

			if (shape is Circle)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
			}
			
			else if (shape is Rectangle) //squere eller rectangle
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
			}
			
			else if (shape is Cuboid) // cube eller cuboid

			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
			}

			else if (shape is Sphere)
			{
				Console.ForegroundColor = ConsoleColor.DarkBlue;
			}

			Console.WriteLine(shape);
			Console.ResetColor();
		}

		
		Console.WriteLine($"\nGenomsnittligt Area: {averageArea}");
	}
}