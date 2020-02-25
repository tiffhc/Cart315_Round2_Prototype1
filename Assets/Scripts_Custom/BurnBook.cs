using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnBook : MonoBehaviour
{
    public GameObject book;
    public GameObject MessagePanel;
    public GameObject key;
    
    public float time = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            if (gameObject.("fire") == null)
                {
                    Destroy(book);
                    OpenMessagePanel("");
                    key.SetActive(true);
                }
        }

    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        CloseMessagePanel();
    }


    public void OpenMessagePanel(string text)
    {
        MessagePanel.SetActive(true);
    }

    public void CloseMessagePanel()
    {
        MessagePanel.SetActive(false);
    }
}
