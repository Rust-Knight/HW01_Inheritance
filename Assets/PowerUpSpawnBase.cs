using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnBase : MonoBehaviour
{

    [SerializeField] 

    private GameObject PowerUP;

    public Transform spawnPoint;

    void Start()
    {
        
    }

   
    public void SpawnPowerUP()
    {

        //GameObject newObject = Instantiate(PowerUP);
        Instantiate(PowerUP, spawnPoint.position, spawnPoint.rotation);
        

    }


}
