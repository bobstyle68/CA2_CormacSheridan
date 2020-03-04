using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : HealthComponent
{

    public GameManager gameManager;
    public GameObject Splatter;

    private void Start()
    {
        gameManager =GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    public override void KillCharacter()
    {
        gameManager.RecordZombieHealth();
        Instantiate(Splatter, transform.position, Quaternion.identity);

        base.KillCharacter();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            ApplyDamage(10);
        }
    }
}
