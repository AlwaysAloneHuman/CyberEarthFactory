using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace CyberEarthFactory.Scripts.Engine
{
    public static class GameStorage
    {
        public static Dictionary<string, Texture2D> defaultTextures;
        public static void Initialize()
        {
            defaultTextures = new Dictionary<string, Texture2D>();
        }
    }
}
