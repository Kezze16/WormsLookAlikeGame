using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    private int playerIndex;

    //Making a playerindex to seperate difftent players.
    public void SetPlayerTurn(int index)
    {
        playerIndex = index;
    }
    
    //Accsess to the other script of when it is the players turn.
    public bool IsPlayerTurn()
    {
        return TurnManager.GetInstance().IsItPlayerTurn(playerIndex);
    }
}
