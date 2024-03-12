using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Test_MonoGame
{
	internal class ObjectClass
	{
		int spriteId;
		Texture2D objectTexture;
		Vector2 location;

		Vector2 velocity;

		public ObjectClass(int spriteId, Texture2D objectTexture)
		{
			this.spriteId = spriteId;
			this.objectTexture = objectTexture;
		}


		public void SetLocation(float x_location, float y_location)
		{
			this.location = new Vector2(x_location, y_location);
		}

		public Vector2 GetLocation() 
		{
			return this.location;
		}

		public Texture2D GetTexture()
		{
			return this.objectTexture;
		}

	}
}
