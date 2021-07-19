using UnityEngine;

namespace Gun
{
    public abstract class GunFactory 
    {
        public abstract int ammo{get; set;}

        public abstract Shot ConcreteShot();
        public virtual Bullet ConcreteBullet()
        {
            return null;
        }
        public abstract GunSound ConcreteSound();
    }
}