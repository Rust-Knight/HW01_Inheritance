using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    public float multiplier = 1f;

    void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            StartCoroutine (Pickup() );
        }

        IEnumerator Pickup()
        {
            TurretController firechange = GetComponent<TurretController>();
            //firechange.FireCooldown *= multiplier;

            //FireCooldown *= 2;
            Debug.Log("PowerUp is Acctive");

            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds(2);

            Debug.Log("PowerUp is DeAcctive");
            
            Destroy(gameObject);
            
        }

    }
}
