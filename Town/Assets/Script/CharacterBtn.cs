using UnityEngine;

public class CharacterBtn : MonoBehaviour
{
    public GameObject characterSelect;
    public void OnClickThis()
    {
        characterSelect.SetActive(true);
    }
}


