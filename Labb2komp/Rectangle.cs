using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
	public class Rectangle : Shape2d
	{
		private readonly Vector2 CenterPosition;
		private readonly Vector2 Size;

		public Rectangle(Vector2 center, Vector2 size)
		{
			CenterPosition = center;
			Size = size;
		}

		public Rectangle(Vector2 center, float width)
		{
			CenterPosition = center;
			Size = new Vector2(width, width);
		}

		public override Vector3 Center => new Vector3(CenterPosition, 0);
		public override float Area => Size.X * Size.Y;
		public override float Circumference => 2 * (Size.X + Size.Y);

		public bool IsSquare => Size.X == Size.Y;

		public override string ToString()
		{
			if (IsSquare)
			{
				return $"square @({CenterPosition.X}, {CenterPosition.Y}): w = {Size.X}";
			}
			else
			{
				return $"rectangle @({CenterPosition.X}, {CenterPosition.Y}): w = {Size.X}, h = {Size.Y}";
			}
		}
	}

}
