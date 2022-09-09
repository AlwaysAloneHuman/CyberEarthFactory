using System;

namespace CyberEarthFactory
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new CyberEarthFactory())
                game.Run();
        }
    }
}
