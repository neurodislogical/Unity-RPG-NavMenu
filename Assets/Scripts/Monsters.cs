using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ProjectRPG
{
    public class Monsters : Character 
    {

        
        //Refrences Character Class
        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
        }

        public override void Death()
        {
            Debug.Log("Monster has been defeated.");
        }

    }
}
