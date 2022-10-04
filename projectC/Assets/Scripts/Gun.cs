using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    
    [SerializeField] private PlayerTurn playerTurn;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    public int Ammo = 5;




    private void Update()
    {
        //This method will spawn the bullet prefab and will shot from the bullet spawn who is attached with the gun gameObject. This also is a method
        //To determain when is the next person's turn. 

        //The player has 5 shoots and cant shoot more then 5 shoot until is the player 1 turn what this method dose. 
        if (playerTurn.IsPlayerTurn() && Ammo > 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                Ammo--;
                Destroy(bullet, 3f);


            }




        }
        if(!playerTurn.IsPlayerTurn())
        {
            Ammo = 5;
        }


    }











}
