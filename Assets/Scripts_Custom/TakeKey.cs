using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    public GameObject key;
    public GameObject kmessage;
    public GameObject door; 

    public bool keytaken = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player2"))
        {
            Destroy(key);
            kmessage.SetActive(true);

            door.transform.Rotate(0, 65.0f, 0); 
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
