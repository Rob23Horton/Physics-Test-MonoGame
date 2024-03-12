using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Test_MonoGame
{
	internal class BallClass
	{

		ObjectClass ballObject;
		Vector2 velocity;

		public BallClass(Texture2D ballTexture, Vector2 start_location)
		{
			this.ballObject = new ObjectClass(0, ballTexture);
			velocity = new Vector2(0, 0);

			this.ballObject.SetLocation(start_location.X, start_location.Y);
		}

		public Vector2 GetLocation()
		{
			return this.ballObject.GetLocation();
		}

		public Texture2D GetTexture()
		{
			return this.ballObject.GetTexture();
		}
	}
}
