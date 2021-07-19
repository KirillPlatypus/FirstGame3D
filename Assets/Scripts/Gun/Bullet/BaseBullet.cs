using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseBullet : Bullet
{
    public override float LifeTime {get;set;} = 1f;
    public override float Speed{get; set;} = 2f;

    public override int damage{get; set;} = 20;

    Rigidbody body;

   
    private void Awake() 
    {
        body = GetComponent<Rigidbody>();    
    }
    public override void Flight()
    {
        body.velocity += transform.forward * Speed;
    }
}
