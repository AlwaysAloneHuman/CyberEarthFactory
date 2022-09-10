using CyberEarthFactory.Scripts.Engine;
using Microsoft.Xna.Framework.Input;

namespace CyberEarthFactory.Scripts.Game.Objects
{
    public sealed class Player : Entity
    {
        public override void Update(float elapsed)
        {
            if (GameInput.IsPressed(Keys.W)) position.Y -= elapsed * 64;
            if (GameInput.IsPressed(Keys.S)) position.Y += elapsed * 64;

            if (GameInput.IsPressed(Keys.A)) position.X -= elapsed * 64;
            if (GameInput.IsPressed(Keys.D)) position.X += elapsed * 64;

            base.Update(elapsed);
        }
        public Player()
        {
            texture = GameStorage.defaultTextures["player"];
            position = GameMath.ScreenSize / 2;
        }
    }
}
