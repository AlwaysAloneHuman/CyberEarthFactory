using CyberEarthFactory.Scripts.Engine;
using CyberEarthFactory.Scripts.Game.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CyberEarthFactory
{
    public sealed class CyberEarthFactory : Game
    {
        public static CyberEarthFactory instance;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public CyberEarthFactory()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            instance = this;

            GameStorage.Initialize();

            GameState.activeState = new GameState();

            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            GameStorage.defaultTextures.Add("null", Content.Load<Texture2D>("Images/Player"));
            GameStorage.defaultTextures.Add("player", Content.Load<Texture2D>("Images/Player"));

            GameState.activeState.members.Add(new Player());

            // TODO: use this.Content to load your game content here
        }
        protected override void Update(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            GameInput.Update();

            GameState.activeState.Update(elapsed);

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.WhiteSmoke);

            _spriteBatch.Begin();
            foreach (var spr in GameState.activeState.members) DrawSprite(spr);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        private void DrawSprite(GameSprite sprite)
        {
            _spriteBatch.Draw(
                sprite.texture,
                new Rectangle((int)sprite.position.X, (int)sprite.position.Y, (int)sprite.size.X, (int)sprite.size.Y),
                null,
                sprite.color,
                GameMath.Deg2Rad(sprite.angle),
                sprite.size/2,
                SpriteEffects.None,
                0
            );
        }
    }
}
