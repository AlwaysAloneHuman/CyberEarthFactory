namespace CyberEarthFactory.Scripts.Game.Objects
{
    public class Entity : Engine.GameSprite
    {
        public ushort health;
        public virtual void TakeDamage(ushort damage) => health -= damage;
    }
}
