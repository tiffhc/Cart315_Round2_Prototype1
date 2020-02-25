using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Gameover : MonoBehaviour
{
    public GameObject player1; 
    public GameObject player2; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1") || (collision.gameObject.CompareTag("Player2")))
        {
            //wait for player 2 
        }

    }
}
