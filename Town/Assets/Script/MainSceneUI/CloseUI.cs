using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI: MonoBehaviour
{
    public GameObject GameObject;
    // Start is called before the first frame update
    public void OnclickThis()
    {
        GameObject.SetActive(false);
    }
}
