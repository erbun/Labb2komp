using System.Drawing;
using System.Numerics;

namespace Klasser
{

	
	public abstract class Shape
	{
		public abstract Vector3 Center { get; }
		public abstract float Area { get; }

		public string Color { get; set; }


		private static readonly Random random = new Random();

		public static Shape GenerateShape()
		{
			int shapeType = random.Next(0, 6); 

			float x = (float)random.NextDouble() * 10;
			float y = (float)random.NextDouble() * 10;
			float z = (float)random.NextDouble() * 10;
			float size = (float)random.NextDouble() * 10;

			switch (shapeType)
			{
				case 0: 
					return new Circle(new Vector2(x, y), size);
				case 1: 
					return new Rectangle(new Vector2(x, y), new Vector2(size, size * 1.5f));
				case 2: 
					return new Rectangle(new Vector2(x, y), size);
				case 3: 
					return new Cuboid(new Vector3(x, y, z), new Vector3(size, size * 1.5f, size * 2f));
				case 4: 
					return new Cuboid(new Vector3(x, y, z), size);
				case 5: 
					return new Sphere(new Vector3(x, y, z), size);
				default:
					throw new InvalidOperationException("Fel");
			}
		}
	}
}

	

	


