using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTxt : MonoBehaviour
{
    // Start is called before the first frame update
    private Text timeText;
    void Start()
    {
        timeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       timeText.text = DateTime.Now.ToString("HH : mm");
    }
}
