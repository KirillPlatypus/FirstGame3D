using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shot
{
    Transform spawn;
    GameObject bullet;
    public Shot(Transform spawn, GameObject bullet) : base()
    {
        this.spawn = spawn;
        this.bullet = bullet;
    }

    public virtual void Shoot()
    {
        GameObject.Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
    }
}

