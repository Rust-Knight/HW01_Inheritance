using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{


    public float reduceSpeed = 0;
    public float recoverSpeed = .05f;

    private void Update()
    {
       
    }

    protected override void OnHit()
    {

        StartCoroutine(Delay());

        IEnumerator Delay()
        {

            MoveSpeed = reduceSpeed;

            yield return new WaitForSeconds(1F); // This stops the tank from moving for one 1F can be changed if needed

            MoveSpeed = recoverSpeed;
        }
    }
}
