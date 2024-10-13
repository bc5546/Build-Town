using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    public NPC npc;

    public void OnEnable()
    {
        Text text = transform.Find("DialogContent").GetComponent<Text>();
        Debug.Log(npc.npcText);
        text.text= npc.npcText;
    }

    public void Update()
    {
        npc.conversationOn = true;
    }
    // Start is called before the first frame update
    public void OnClickThis()
    {
        npc.transform.GetComponent<NPC>().conversationOn = false;
        gameObject.SetActive(false); 
    }
}
