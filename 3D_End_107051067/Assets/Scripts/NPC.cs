using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPC : MonoBehaviour
{
    [Header("NPC資料")]
    public NPCData1   Data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話者名稱")]
    public Text textName;
    [Header("對話間隔")]
    public float interval;

    public bool playerInarea;

    public enum NPCState
    {
        FirstDialog, Missioning, Finish
    }

    public NPCState state = NPCState.FirstDialog;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Carino")
        {
            playerInarea = true;
            StartCoroutine(dialoug());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Carino")
        {
            playerInarea = false;
            Stopdialog();
        }
    }

    private void Stopdialog()
    {
        dialog.SetActive(false);
        StopAllCoroutines();
    }

    private IEnumerator dialoug()
    {
        dialog.SetActive(true);
        textContent.text = "";
        textName.text = name;
        string dialogString = Data.dialougB;

        switch (state)
        {
            case NPCState.FirstDialog:
                dialogString = Data.dialougA;
                break;  
            case NPCState.Missioning:
                dialogString = Data.dialougB;
                break;
            case NPCState.Finish:
                dialogString = Data.dialougC;
                break;
        }

        for (int i = 0; i < dialogString.Length; i++)
        {
            textContent.text += dialogString[i] + "";
            yield return new WaitForSeconds(interval);
        }
    }
}
