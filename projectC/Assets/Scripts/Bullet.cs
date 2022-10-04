using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // How mutch Dmg it will make to the player 1 or player 2
    public int damage = 2;

    // This method is used when the bullet is colliding with players it will do damage on the tag "player" and after i will be destoyed. Same if it dose not hit anything 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);

        }

        Destroy(this.gameObject);
        
    }

}
