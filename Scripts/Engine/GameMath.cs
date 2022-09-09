using System;

namespace CyberEarthFactory.Scripts.Engine
{
    public static class GameMath
    {
        public const float D2R = (float)(Math.PI / 180);
        public static float Deg2Rad(float degress) => degress * D2R;
    }
}
