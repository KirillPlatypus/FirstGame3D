using UnityEngine;

namespace Gun
{
    public abstract class GunFactory 
    {
        public abstract int ammo{get; set;}

        public abstract Shot ConcreteShot();
        public abstract Bullet ConcreteBullet();
        public abstract GunSound ConcreteSound();
    }
    public class PistolFactory : GunFactory
    {
        public override int ammo{get; set;} 
        Transform spawn;
        GameObject bullet;
        public PistolFactory(Transform spawn, GameObject bullet)
        {
            this.spawn = spawn;
            this.bullet = bullet;
        }

        public override Shot ConcreteShot()
        {
            return new BaseShot(spawn, bullet);
        }
        public override Bullet ConcreteBullet()
        {
            return new BaseBullet();
        }
        public override GunSound ConcreteSound()
        {
            return new PistolSound();
        }

    }


}