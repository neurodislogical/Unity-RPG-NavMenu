using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ProjectRPG
{
    public class Character : MonoBehaviour
    {
        //Chararter Properties
        public int Health { get; set; }
        public int ExperiencePoints { get; set; }
        public int Coins { get; set; }
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int Level { get; set; }

        public Vector2 LocationIndex { get; set; }
        public List<string> Inventory { get; set; }
        public List<string> Quests { get; set; }

        
        
        
        
        //Possible Functionality
        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0)
            {
                Death();
            }
        }

        public virtual void Death()
        {
            Debug.Log("You have been defeated.");
        }
    }
}
