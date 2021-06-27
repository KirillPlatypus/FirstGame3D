using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShot : Shot
{
    Transform spawn;
    GameObject bullet;
    public BaseShot(Transform spawn, GameObject bullet) : base(spawn, bullet)
    {
    }
}
