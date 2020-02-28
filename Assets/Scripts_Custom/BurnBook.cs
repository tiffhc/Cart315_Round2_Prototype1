using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnBook : MonoBehaviour
{
    public GameObject book;
    public GameObject MessagePanel;
    public GameObject key;

    public CollectFire CF;
    
    public float time = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            if (CF.fireDestroyed == true)
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
