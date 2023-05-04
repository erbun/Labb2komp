using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Klasser
{
	public class Cuboid : Shape3d
	{
		private readonly Vector3 CenterPosition;
		private readonly Vector3 Size;

		public Cuboid(Vector3 center, Vector3 size)
		{
			CenterPosition = center;
			Size = size;

		}

		public Cuboid(Vector3 center, float width)
		{
			CenterPosition = center;
			Size = new Vector3(width, width, width);
		}

		public override Vector3 Center => CenterPosition;
		public override float Area => 2 * (Size.X * Size.Y + Size.Y * Size.Z + Size.X * Size.Z);
		public override float Volume => Size.X * Size.Y * Size.Z;

		public bool IsCube => Size.X == Size.Y && Size.Y == Size.Z;


		public override string ToString()
		{
			if (IsCube)
			{
				return $"cube @({CenterPosition.X}, {CenterPosition.Y}, {CenterPosition.Z}): w = {Size.X}";
			}
			else
			{
				return
					$"cuboid @({CenterPosition.X}, {CenterPosition.Y}, {CenterPosition.Z}): w = {Size.X}, h = {Size.Y}, l = {Size.Z}";
			}
		}
	
}

}
