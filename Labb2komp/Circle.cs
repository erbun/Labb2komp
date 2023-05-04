using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
	public class Circle : Shape2d

	{
		private readonly Vector2 CenterPosition;
		private readonly float Radius;


		public Circle(Vector2 centerPosition, float radius)
		{
			CenterPosition = centerPosition;
			Radius = radius;
		}

		public override Vector3 Center => new Vector3(CenterPosition, 0);
		public override float Area => (float)Math.PI * Radius * Radius;
		public override float Circumference => 2 * (float)Math.PI * Radius;
		
		public override string ToString()
		{
			return $"circle @({CenterPosition.X}, {CenterPosition.Y}: r ={Radius}";
		}
	}


}
