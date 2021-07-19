using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShot : Shot
{
    public BaseShot(Transform spawn, GameObject bullet)
    {
        this.spawn = spawn;
        this.bullet = bullet;
    }
}
