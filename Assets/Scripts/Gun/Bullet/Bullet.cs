using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public abstract float LifeTime{get; set;}
    public abstract float Speed{get; set;}
   
    public virtual void Update()
    {
        Flight();

        StartCoroutine(DestroyObject());
    }
    public abstract void Flight();
   
    public virtual IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(gameObject);
    }
    public virtual void Damege(){}
}
