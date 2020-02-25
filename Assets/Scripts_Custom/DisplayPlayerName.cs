using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DisplayPlayerName : MonoBehaviour
{
    public Text display_win; 
    // Start is called before the first frame update
    void Start()
    {
        showWinner(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showWinner()
    {
        if (Gameover.winner == "Player1")
        {
            display_win.text = "Player 1";
        }
        else if (Gameover.winner == "Player2")
        {
            display_win.text = "Player 2"; 
        }
    }
}
