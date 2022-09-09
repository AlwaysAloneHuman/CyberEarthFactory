using System.Collections.Generic;

namespace CyberEarthFactory.Scripts.Engine
{
    public class GameState
    {
        public static GameState activeState;

        public List<GameSprite> members;
        public GameState()
        {
            members = new List<GameSprite>();
        }
        public virtual void Initialize() { }
        public virtual void Update(float elapsed)
        {
            foreach (var memb in members) memb.Update(elapsed);
        }
    }
}
