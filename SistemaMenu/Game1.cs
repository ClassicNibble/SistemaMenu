using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Clases;


namespace paniqueados2
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _textura;
        static int LimitX = 1000;
        static int LimitY = 700;

        public List<Vector2> pixelScreen = new List<Vector2>();

        SpriteFont font;
        Texture2D pixel;
        MotorMenu motorMenu = new MotorMenu();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData<Color>(new Color[1] { Color.White });
            _graphics.PreferredBackBufferWidth = LimitX;
            _graphics.PreferredBackBufferHeight = LimitY;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();
            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("assets/File");
            _textura = Content.Load<Texture2D>("assets/puntito");
            motorMenu.LoadContent(Content, _graphics);
        }
        protected override void Update(GameTime gameTime)
        {
            motorMenu.Update();
            base.Update(gameTime);

        }
        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            //EMPEZAR A DIBUJAR
            _spriteBatch.Begin();
            /// MENU
            motorMenu.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}
