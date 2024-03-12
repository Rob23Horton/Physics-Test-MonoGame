using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Physics_Test_MonoGame
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		List<BallClass> balls = new List<BallClass>();

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here


			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here

			Texture2D ballSprite = Content.Load<Texture2D>("target");

			balls.Append(new BallClass(ballSprite, new Vector2(150, 150)));

            Debug.WriteLine("Hello World");

        }

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            Console.WriteLine("Draw");

            _spriteBatch.Begin();

			//GraphicsDevice.Clear(Color.White);

			foreach (BallClass ball in this.balls)
			{
                Console.WriteLine("Display");
                _spriteBatch.Draw(ball.GetTexture(), ball.GetLocation(), Color.White);
			}

			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
