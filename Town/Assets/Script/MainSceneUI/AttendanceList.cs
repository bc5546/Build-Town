using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendanceList : MonoBehaviour
{
    public Text attendanceTxt;
    // Start is called before the first frame update
    public void OnEnable()
    {
        attendanceTxt.text = "";
        foreach(string attendance in AttendanceTxtManager.Instance.attendanceList)
        {
            attendanceTxt.text += attendance+"\n";
        }
    }
}
