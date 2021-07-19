using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Damage;

public class RayShot : Shot
{
    RaycastHit hit;

    int distance;
    int damage;

    private DamageSystem dam;

    Transform endSpawn;


    public RayShot(int distance, Transform spawn, int damage)
    {
        this.distance = distance;
        this.spawn = spawn;
        this.damage = damage;
    }

    public override void Shoot()
    {
        if(Physics.Raycast(spawn.position, spawn.forward, out hit, distance))
        {
            if(hit.collider.tag == "Enemy")
            {
                var enemyComponent = hit.collider.GetComponent<IGetDamage>();

                if(enemyComponent != null)
                {
                    dam = new DamageSystem(enemyComponent);

                    dam.TakeDamege(damage);
                }
            }
        }        
    }
}
