using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 2;
    int Damage = 10;
    public HealthComponent healthComp;

    private void Start()
    {
        Invoke("DestroyBullet", 2);
    }

    //sets the velocity of the bullet
    public void SetDirection(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }

    //can be extended by later (virtual)
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        ApplyDamageToHealth(collision.gameObject);
        DestroyBullet();
    }

    //can be extended by later (virtual)
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        ApplyDamageToHealth(collision.gameObject);
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    public void ApplyDamageToHealth(GameObject collide)
    {
        healthComp = collide.GetComponent<HealthComponent>();
        if(healthComp!=null)
        healthComp.ApplyDamage(Damage);
        
    }

}
