using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float startTime;
    public Text timerText;
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Reset");
            
            startTime = Time.time - Time.time;
        }

        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        
        timerText.text = minutes + ":" + seconds;
    }

    void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    
}
