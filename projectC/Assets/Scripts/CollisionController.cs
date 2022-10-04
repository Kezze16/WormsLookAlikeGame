using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{

    // A simple collison controller to determain were the player is in the game world.


    private void OnCollisionEnter(Collision collision)
    {
        print("Landed on " + collision.gameObject.name);

    }

    private void OnCollisionStay(Collision collision)
    {
        print("Walking on the " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Leaving the " + collision.gameObject.name);
    }

   









}
