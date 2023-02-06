using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnBase : MonoBehaviour
{

    [SerializeField] 

    private GameObject PowerUP; // prefab reference game object

    public Transform spawnPoint; // The position of spawn location for prefab

    void Start()
    {
        
    }

   
    public void SpawnPowerUP()
    {
        Instantiate(PowerUP, spawnPoint.position, spawnPoint.rotation); // Use position and rotation of gameObject for assign to location of prefab 

    }


}
