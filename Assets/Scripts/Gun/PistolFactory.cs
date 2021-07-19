using UnityEngine;

namespace Gun
{
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
    public class PistolRayFactory : GunFactory
    {
        public override int ammo{get; set;} 

        int distance;

        int damage;

        Transform spawn;
        Transform endSpawn;

        public PistolRayFactory(int distance, Transform spawn, int damage)
        {
            this.distance = distance;
            this.spawn = spawn;
            this.damage = damage;
        }

        public override Shot ConcreteShot()
        {
            return new RayShot(distance, spawn, damage);
        }
        public override GunSound ConcreteSound()
        {
            return new PistolSound();
        }

    }



}