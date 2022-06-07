using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer_text;
    public float time;

    public static bool time_pause;

    void Awake()
    {
        time_pause = false;
        timer_text.text = time.ToString();
    }


    void Update()
    {
        if (time > 0)
            time -= Time.deltaTime;

        timer_text.text = Mathf.Ceil(time).ToString();

        //추후 타이머 종료
        /*if(time <= 0)
         *  실패 화면 실행
         */
    }

    public void PauseTimer()
    {
        Time.timeScale = 0.0f;
    }

    public void RestartTimer()
    {
        Time.timeScale = 1.0f;
    }
}
