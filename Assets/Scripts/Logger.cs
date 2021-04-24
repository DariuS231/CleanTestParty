using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logger : MonoBehaviour
{
    private static Logger _instance;

    public static Logger Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }

    [SerializeField]
    Text text;

    public void Log(string message)
    {
        var msg = $"LOG  -   {message}\n";
        Debug.Log (msg);
        text.text += msg;
    }

    public void LogError(string message)
    {
        var msg = $"ERROR    -   {message}\n";
        Debug.LogError (msg);
        text.text += msg;
    }
}
