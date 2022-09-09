using Microsoft.Xna.Framework.Input;

namespace CyberEarthFactory.Scripts.Engine
{
    public static class GameInput
    {
        private static KeyboardState lastKeys = new KeyboardState();
        private static KeyboardState curKeys = new KeyboardState();
        public static void Update()
        {
            lastKeys = curKeys;
            curKeys = Keyboard.GetState();
        }
        public static bool IsPress(Keys key) => !lastKeys.IsKeyDown(key) && curKeys.IsKeyDown(key);
        public static bool IsPressed(Keys key) => curKeys.IsKeyDown(key);
        public static bool IsRelease(Keys key) => lastKeys.IsKeyDown(key) && !curKeys.IsKeyDown(key);
    }
}
