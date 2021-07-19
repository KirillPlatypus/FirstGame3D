using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shot
{
    protected Transform spawn;
    protected GameObject bullet;
   
    public virtual void Shoot()
    {
        GameObject.Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
    }

}

