using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFire : MonoBehaviour
{
    public GameObject fire;
    public GameObject MessagePanel;
    public bool fireDestroyed = false;

    public float time = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Destroy(fire);
            fireDestroyed = true;
            OpenMessagePanel("");

            Debug.Log("FIRE destroyed!");
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
