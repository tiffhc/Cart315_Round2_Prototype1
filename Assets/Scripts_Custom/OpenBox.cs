using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject box;
    public GameObject key; 
    public GameObject message; 


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player2"))
        {
            Debug.Log("Inside box collider"); 
            Destroy(box);
            key.SetActive(true);
            message.SetActive(true); 
        }
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
