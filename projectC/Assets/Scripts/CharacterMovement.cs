using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    public Rigidbody _rb;
    public bool playerIsOnTheGround = true;

    [SerializeField] private float _playerSpeed = 5f;
    [SerializeField] private int _playerIndex;


    // Gets accsess to the gameObjects Rigidbody
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //The players movment
        if (playerTurn.IsPlayerTurn()) 
        {
            float hor = Input.GetAxis("Horizontal") * Time.deltaTime * _playerSpeed;
            float ver = Input.GetAxis("Vertical") * Time.deltaTime * _playerSpeed;

            transform.Translate(hor, 0, ver);

            //How the player can Jump.
            if (Input.GetButtonDown("Jump") && playerIsOnTheGround)
            {
                _rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
                playerIsOnTheGround = false;
            }


        }

    }



    //To check if the player is on the ground or on the floor
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            playerIsOnTheGround = true;
        }
    }
}
