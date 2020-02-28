using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RM2_CollectFire : MonoBehaviour
{
    public GameObject fire2; 
    public GameObject MessagePanel2;
    public Player2_Move p;

    public GameObject box; 
    //public Text fireMessage;
   

    //float timeLeft = 5.0f; //5 second float time

    //public static int num_fire_destroyed = 0;
    //public bool fireDestroyed = false;

    public void OpenMessagePanel()
    {
        MessagePanel2.SetActive(true);
    }

    public void CloseMessagePanel()
    {
        MessagePanel2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player2")) //player touches one of the two candles 
        {
            Destroy(fire2);
            //fireMessage.text = "- Fired destroyed -";
            OpenMessagePanel();
            Player2_Move.num_fire += 1;
            Debug.Log(Player2_Move.num_fire); 

            if(Player2_Move.num_fire == 2)
            {
                createBox(); 
            }

            //3 cases:
            //  1 - player collides with Fire 2_1 first
            // 2 - player collides with Fire 2_2 first

            /*
            if (this.gameObject.CompareTag("Fire2_1"))
           {
                Destroy(fire2_1);
                num_fire_destroyed++;
                fireMessage.text = "- " + num_fire_destroyed + " Fired destroyed -";
                OpenMessagePanel();

            }
           else if (this.gameObject.CompareTag("Fire2_2"))
           {
                Destroy(fire2_1);
                num_fire_destroyed++;
                fireMessage.text = "- " + num_fire_destroyed + " Fired destroyed -";
                OpenMessagePanel();

                
            }
           */ 


            //wait(); 
  
            /*
            if (num_fire_destroyed == 2)
            {
                fireMessage.text = "- All fire destroyed! -";
                OpenMessagePanel(); 
                // Debug.Log("Both fired destroyed");
            }
            */ 
        }
    }


    /*
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5); //wait 5 seconds before closing 
        CloseMessagePanel(); 
    }
    */


    void createBox()
    {
      box.SetActive(true);
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
