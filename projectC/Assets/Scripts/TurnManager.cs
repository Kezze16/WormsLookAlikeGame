using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class TurnManager : MonoBehaviour
{

    [SerializeField] private PlayerTurn playerOne;
    [SerializeField] private PlayerTurn playerTwo;
    [SerializeField] public float turnDuration;
    [SerializeField] private Camera cam1;
    [SerializeField] private Camera cam2;

    public float currentTime;
    private int currentPlayerIndex;
    private static PlayerTurn playerTurn;
    private static TurnManager instance;
    public int bulletAmount = 5;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
        }

    }

    private void Update()
    {
        currentTime += Time.deltaTime;

       //Changes camera when the turn switch
       // The turn is time based and after the timeDuration input in inspector will determinane how long the player will have to try to kill the other player. 
        if(currentTime >= turnDuration)
        {
            
            
            if(currentPlayerIndex == 1)
            {
                cam1.depth = 0;
                cam2.depth = 1;
            }

            if (currentPlayerIndex == 2)
            {
                cam1.depth = 1;
                cam2.depth = 0;
            }

            currentTime = 0;
            ChangeTurn();
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeTurn();
        }

       
    }

    public bool IsItPlayerTurn(int index)
    {
        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    //Looks if it the player 1 turn or players 2 turn.
    public void ChangeTurn()
    {
        
        if(currentPlayerIndex == 1)
        {
            
            currentPlayerIndex = 2;
           
               
        }
        else if(currentPlayerIndex == 2)
        {
            
            currentPlayerIndex = 1;
            
        }

    }





}
