using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneBtn : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnClickThis()
    {
        string characterName = GameObject.Find("Canvas/InputField/Text").GetComponent<Text>().text;
        CharacterManager.Instance.characterName = characterName;
        SceneManager.LoadScene("MainScene");
    }
}
