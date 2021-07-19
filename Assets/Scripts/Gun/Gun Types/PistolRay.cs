using UnityEngine;
using System;
using UnityEngine.Audio;
using Gun.Modifications;

namespace Gun
{
    public class PistolRay : MonoBehaviour
    {        
        [SerializeField] Transform spawn;

        [SerializeField] int damage;
        [SerializeField] int distance;

        [SerializeField] int maxAmmo;

        [SerializeField] AudioSource source;

        IAudioModification audioModification;
        IAmmoModification ammoModification;

        float time;
        GunFactory pistol;
        Shot shot;
        GunSound sound;

        private void Awake() 
        {
            pistol = new PistolRayFactory(distance, spawn, damage);
            shot = pistol.ConcreteShot();
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

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(spawn.position, spawn.forward);
        }
    }
}