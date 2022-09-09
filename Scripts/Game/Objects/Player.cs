using CyberEarthFactory.Scripts.Engine;
using Microsoft.Xna.Framework.Input;

namespace CyberEarthFactory.Scripts.Game.Objects
{
    public sealed class Player : Entity
    {
        public override void Update(float elapsed)
        {
            if (GameInput.IsPressed(Keys.W)) position.Y -= elapsed;
            if (GameInput.IsPressed(Keys.S)) position.Y += elapsed;

            if (GameInput.IsPressed(Keys.A)) position.X -= elapsed;
            if (GameInput.IsPressed(Keys.D)) position.X += elapsed;

            base.Update(elapsed);
        }
    }
}
