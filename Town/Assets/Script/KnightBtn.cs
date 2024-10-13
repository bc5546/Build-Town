using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KnightBtn : MonoBehaviour
{
    public void OnClickThis()
    {
        GameObject.Find("Canvas/CharacterBtn/Penguin").gameObject.SetActive(false);
        GameObject.Find("Canvas/CharacterBtn/Knight").gameObject.SetActive(true);
        CharacterManager.Instance.characterType = "Knight";
        GameObject.Find("Canvas/CharacterSelect").gameObject.SetActive(false);
    }
}
