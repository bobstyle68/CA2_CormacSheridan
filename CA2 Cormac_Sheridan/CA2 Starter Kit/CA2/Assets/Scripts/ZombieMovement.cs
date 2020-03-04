using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    GameObject player;
    public float movementSpeed = 100;
    public float trackingRange = 5;
    Rigidbody2D body;
    Vector2 direction;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = player.transform.position - transform.position;
        transform.up = direction;

        if (Vector3.Distance(transform.position, player.transform.position <= trackingRange))
        {

        }
        
    }
}
