using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{


    protected override void OnHit()
    {
        Delay();
        //MoveSpeed *= 0;
        //Invoke(MoveSpeed, 1);

        void Delay()
        {
            MoveSpeed *= 0;
        }

        void Resume()
        {
             MoveSpeed *= 1;
        }

       

    }

   


}
