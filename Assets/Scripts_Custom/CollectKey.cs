using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public GameObject key;
    public GameObject MessagePanel;
    public GameObject door;

    public CollectMagnet CM;

    public float time = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            if (CM.magnetDestroyed == true)
            {
                Destroy(key);
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
