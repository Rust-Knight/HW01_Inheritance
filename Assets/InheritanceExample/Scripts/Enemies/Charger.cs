using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    //public PowerUpSpawnBase powerUPS;

    void Start()
    {
        powerUPS = GameObject.FindObjectOfType<PowerUpSpawnBase>();
    }


    protected override void OnHit()
    {
        MoveSpeed *= 2;

    }

    public override void Kill()
    {
        //TODO put code you want to happen before disable here

        
        powerUPS.SpawnPowerUP();

        // this runs the base method AND what's above it here
        base.Kill();
    }
}
