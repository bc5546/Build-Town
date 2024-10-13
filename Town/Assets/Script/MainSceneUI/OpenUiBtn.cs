using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUiBtn : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    public void OnClickThis()
    {
        UI.SetActive(true);
    }
}
