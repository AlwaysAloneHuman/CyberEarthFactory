using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CyberEarthFactory.Scripts.Engine
{
    public class GameSprite
    {
        public Vector2 position;
        public Vector2 size;
        private Texture2D _texture = CyberEarthFactory.defaultTexture;
        public Texture2D texture { get { return _texture; } set { _texture = value; size.X = value.Width; size.Y = value.Height; } }
        public Color color = Color.White;
        public float angle;
        public virtual void Update(float elapsed) { }
    }
}
