using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
	public class Sphere : Shape3d
	{
		private readonly Vector3 CenterPosition;
		private readonly float Radius;

		public Sphere(Vector3 center, float radius)
		{
			CenterPosition = center;
			Radius = radius;
		}

		public override Vector3 Center => CenterPosition;
		public override float Area => 4 * (float)Math.PI * Radius * Radius;
		public override float Volume => (4.0f / 3.0f) * (float)Math.PI * Radius * Radius * Radius;

		public override string ToString()
		{
			return $"sphere @({CenterPosition.X}, {CenterPosition.Y}, {CenterPosition.Z}): r = {Radius}";
		}


	}


}
