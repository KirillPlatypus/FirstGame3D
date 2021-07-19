using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Damage;

public abstract class Bullet : MonoBehaviour
{
    public abstract float LifeTime{get; set;}
    public abstract float Speed{get; set;}
    public abstract int damage {get; set;}
    private DamageSystem dam;
    IGetDamage enemyComponent;
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

    public virtual void OnCollisionEnter(Collision other) 
    {
        if(other.collider.tag == "Enemy")
        {
            enemyComponent = other.collider.GetComponent<IGetDamage>();

            if(enemyComponent != null)
            {
                dam = new DamageSystem(enemyComponent);

                dam.TakeDamege(damage);

                Destroy(gameObject);
            }
        }
    }
}
