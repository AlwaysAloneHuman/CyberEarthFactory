using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CyberEarthFactory.Scripts.Engine
{
    public class GameSprite
    {
        public Vector2 position;
        public Vector2 size;
        protected Texture2D _texture;
        public Texture2D texture { get { return _texture; } set { _texture = value; size.X = value.Width; size.Y = value.Height; } }
        public Color color = Color.White;
        public float angle;
        public virtual void Update(float elapsed) { }
        public GameSprite()
        {
            texture = GameStorage.defaultTextures["null"];
        }
    }
}
