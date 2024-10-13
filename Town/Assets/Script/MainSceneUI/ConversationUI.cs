using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationUI : MonoBehaviour
{
    public NPC npc;
    public GameObject dialogUI;

    // Start is called before the first frame update
    public void OnClickThis()
    {
        dialogUI.GetComponent<DialogUI>().npc = npc;
        dialogUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
