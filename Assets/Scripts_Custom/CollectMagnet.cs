using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMagnet : MonoBehaviour
{
    public GameObject magnet;
    public GameObject MessagePanel;
    public bool magnetDestroyed = false;

    public float time = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Destroy(magnet);
            magnetDestroyed = true;
            OpenMessagePanel("");

            Debug.Log("MAGNET destroyed!");
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
