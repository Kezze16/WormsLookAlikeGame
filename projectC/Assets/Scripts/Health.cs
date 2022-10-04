using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Declaring the Players health
    public int health;
    public int maxHealth = 10;
  

    // What the player start as healt
    private void Start()
    {
        health = maxHealth;
    }

   //Made a public method were the bullet can start to do dmg when colliding. And when the player hitpoint are 0 it destory " kill " the player object.
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
