using UnityEngine;
using System;
using UnityEngine.Audio;
using Gun.Modifications;

namespace Gun
{
    public class Pistol : MonoBehaviour
    {
        [SerializeField] Transform spawn;

        [SerializeField] GameObject bulletOriginal;
        [SerializeField] int maxAmmo;

        [SerializeField] AudioSource source;

        IAudioModification audioModification;
        IAmmoModification ammoModification;

        float time;
        GunFactory pistol;
        Shot shot;
        Bullet bullet;
        GunSound sound;
        private void Awake() 
        {
            pistol = new PistolFactory(spawn, bulletOriginal);
            shot = pistol.ConcreteShot();
            bullet = pistol.ConcreteBullet();
            sound = pistol.ConcreteSound();
            sound.source = source;

            pistol.ammo = this.maxAmmo;
            try
            {
                var audioMod = GameObject.FindGameObjectsWithTag("AudioModification");
                var ammoMod = GameObject.FindGameObjectsWithTag("AmmoModification");

                if(audioMod != null)
                {
                    var audioclip = audioMod[0].GetComponent<IAudioModification>();

                    sound.source.clip = audioclip.clip;
                }

                if(ammoMod != null)
                {
                    var newAmmo = ammoMod[0].GetComponent<IAmmoModification>();

                    maxAmmo = newAmmo.ammo;
                }
            }catch(Exception e)
            {

            }
            
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
                sound.Play();
            }            
        }
    }
}