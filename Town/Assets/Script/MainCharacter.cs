using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] private GameObject characterNameSquare;
    [SerializeField] private GameObject characterNameTxt;
    public string currentCharacter;
    public GameObject conversationUI;
    // Start is called before the first frame update
    void Start()
    {
        characterNameSquare = GameObject.Find("Canvas/CharacterNameSquare");
        characterNameTxt = characterNameSquare.transform.Find("CharacterName").gameObject;
        characterNameTxt.GetComponent<Text>().text = CharacterManager.Instance.characterName;
        transform.Find(CharacterManager.Instance.characterType).gameObject.SetActive(true);
        currentCharacter=CharacterManager.Instance.characterType;
        AttendanceTxtManager.Instance.attendanceList.Add(CharacterManager.Instance.characterName);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void NameChange()
    {
        characterNameTxt.GetComponent<Text>().text = CharacterManager.Instance.characterName;
        AttendanceTxtManager.Instance.attendanceList.Add(CharacterManager.Instance.characterName);
    }

    public void CharacterChange()
    {
        if(currentCharacter!= CharacterManager.Instance.characterType)
        {
            transform.Find(currentCharacter).gameObject.SetActive(false);
            transform.Find(CharacterManager.Instance.characterType).gameObject.SetActive(true);
            currentCharacter= CharacterManager.Instance.characterType;
        }
    }

    public void Conversation(NPC npc)
    {
        conversationUI.SetActive(true);
        conversationUI.transform.Find("NPCName").GetComponent<Text>().text = npc.npcName;
        conversationUI.GetComponent<ConversationUI>().npc = npc;

    }
    public void ConversationOff()
    {
        conversationUI.SetActive(false);
    }
}
