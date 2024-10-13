using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinBtn : MonoBehaviour
{
   public void OnClickThis()
    {
        GameObject.Find("Canvas/CharacterBtn/Penguin").gameObject.SetActive(true);
        GameObject.Find("Canvas/CharacterBtn/Knight").gameObject.SetActive(false);
        CharacterManager.Instance.characterType = "Penguin";
        GameObject.Find("Canvas/CharacterSelect").gameObject.SetActive(false);
    }
}


