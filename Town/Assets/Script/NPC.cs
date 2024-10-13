using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string npcName;
    public string npcText;
    private MainCharacter character;
    public bool conversationOn;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("MainCharacter").GetComponent<MainCharacter>();
        AttendanceTxtManager.Instance.attendanceList.Add(npcName);
    }

    // Update is called once per frame
    void Update()
    {
        if ((character.transform.position - this.transform.position).magnitude < 2.0f&&conversationOn==false) 
        {
            character.Conversation(this);
            conversationOn = true;
        }
        else if ((character.transform.position - this.transform.position).magnitude > 2.0f && conversationOn == true)
        {
            conversationOn= false;
            character.ConversationOff();
        }
    }
}
