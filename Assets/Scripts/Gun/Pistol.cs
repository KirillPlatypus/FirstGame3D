using UnityEngine;
using System;

namespace Scripts.Gun
{
    public class Pistol : MonoBehaviour
    {
        [SerializeField] Transform spawn;

        [SerializeField] GameObject bulletOriginal;
        [SerializeField] int ammo;
        float time;
        GunFactory pistol;
        Shot shot;
        Bullet bullet;
        private void Awake() 
        {
            pistol = new PistolFactory(spawn, bulletOriginal);
            shot = pistol.ConcreteShot();
            bullet = pistol.ConcreteBullet();

            pistol.ammo = this.ammo;
            
            bulletOriginal.AddComponent(bullet.GetType());
        }
        private void Update() 
        {
            time += Time.deltaTime;

            if (Input.GetMouseButton(0) && pistol.ammo > 0 && time > 0.5f)
            {
                shot.Shoot();
                pistol.ammo--;
                time = 0;
            }            
        }
    }
}