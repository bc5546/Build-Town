using UnityEngine;
using UnityEngine.UI;

public class NameChange : MonoBehaviour
{
    public MainCharacter character;
    public GameObject ChangeNameUI;
    public void OnClickThis()
    {
        string characterName = GameObject.Find("Canvas/ChangeNameUI/InputField/Text").GetComponent<Text>().text;
        GameObject.Find("Canvas/ChangeNameUI/InputField").GetComponent<InputField>().text = null;
        AttendanceTxtManager.Instance.attendanceList.Remove(CharacterManager.Instance.characterName);
        CharacterManager.Instance.characterName = characterName;
        character.NameChange();
        AttendanceTxtManager.Instance.ListChanged();
        ChangeNameUI.SetActive(false);
    }
}
