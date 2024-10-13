using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttendanceTxtManager : MonoBehaviour
{
    private static AttendanceTxtManager instance = null;
    public List<string> attendanceList { get; set; }

    public AttendanceList AttendanceListTxt;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        attendanceList = new List<string>();
    }

    public static AttendanceTxtManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }
    public void ListChanged()
    {
        AttendanceListTxt.OnEnable();
    }
}
