using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlSwitcher : MonoBehaviour
{
    bool canEnterVehicle;
    bool isInVehicle;

    GameObject currentVehicle;
    PlayerOnFootMovement playerMovement;
    PlayerAttack playerAttack;

    void Start()
    {
        playerMovement = GetComponent<PlayerOnFootMovement>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnterTrigger") && !isInVehicle)
        {
            canEnterVehicle = true;
            currentVehicle = collision.transform.parent.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnterTrigger") && isInVehicle)
        {
            canEnterVehicle = false;
            currentVehicle = null;
            isInVehicle = false;
        }
    }

    private void Update()
    {
        if (canEnterVehicle && !isInVehicle)
        {
            if (Input.GetKeyDown(KeyCode.E))
                EnterCar();
        }
        else if (isInVehicle)
        {
            if (Input.GetKeyDown(KeyCode.E))
                ExitCar();
        }
    }

    void EnterCar()
    {
        //Update Player
        playerMovement.enabled = false;
        playerMovement.gameObject.GetComponent<Collider2D>().enabled = false;
        playerMovement.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        playerMovement.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;

        playerMovement.gameObject.transform.position = currentVehicle.transform.position;
        playerMovement.gameObject.transform.parent = currentVehicle.transform;

        if (playerAttack.activeWeapon)
            playerAttack.activeWeapon.gameObject.SetActive(false);

        playerAttack.enabled = false;

        //Update Vehicle
        currentVehicle.GetComponent<PlayerVehicleMovement>().enabled = true;
        currentVehicle.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        isInVehicle = true;
    }

    void ExitCar()
    {
        //Update Player
        playerMovement.enabled = true;
        playerMovement.gameObject.GetComponent<Collider2D>().enabled = true;
        playerMovement.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        playerMovement.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;

        playerMovement.gameObject.transform.parent = null;

        if (playerAttack.activeWeapon)
            playerAttack.activeWeapon.gameObject.SetActive(true);

        playerAttack.enabled = true;

        //Update Vehicle
        currentVehicle.GetComponent<PlayerVehicleMovement>().enabled = false;
        currentVehicle.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

        canEnterVehicle = false;
    }
}
