using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    public MainCharacter character;
    public GameObject ChangeCharacterUI;
    public string characterType;
    public void OnClickThis()
    {
        CharacterManager.Instance.characterType = characterType;
        character.CharacterChange();
        
        ChangeCharacterUI.SetActive(false);
    }
}
