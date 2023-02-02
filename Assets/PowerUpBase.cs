using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    public float multiplier = .5f;
    public TurretController playerContoller;
    void Start()
    {
        playerContoller = GameObject.FindObjectOfType<TurretController>(); // finds TurretController script for use! 
    }

    void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            StartCoroutine (Pickup() );
        }

        IEnumerator Pickup()
        {

            
            playerContoller.FireCooldown = .25f; // Sets speed to .25 when hit with bullet 

            //FireCooldown *= 2;
            Debug.Log("PowerUp is disabled");

            GetComponent<MeshRenderer>().enabled = false; // Truns off MeshRenderer
            GetComponent<Collider>().enabled = false; // Turn off Collider still lets the power up eneabled 

            yield return new WaitForSeconds(2);

            playerContoller.FireCooldown = multiplier; // return to normal shoting speed

            Debug.Log("PowerUp is enabled");
            
            Destroy(gameObject);
            
        }

    }
}
