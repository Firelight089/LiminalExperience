using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class DayNight : MonoBehaviour
{
    public float time;
    public TimeSpan currenttime;
    public Transform SunTransform;
    public Light Sun;
    public Text timetext;
    public int days;

    public float intensity;
    public Color fogday = Color.white;
    public Color fognight = Color.grey;

    public float speed;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        ChangeTime ();
    }
    public void ChangeTime()
    {
        time += Time.deltaTime * speed;
        if(time > 3600 )
        {
            days += 1;
            time = 0;
        }
        currenttime = TimeSpan.FromSeconds(time);
        string[] temptime = currenttime.ToString ().Split (":"[0]);
        timetext.text = temptime [0] + ":" + temptime [1];

        SunTransform.rotation = Quaternion.Euler(new Vector3((time - 900) / 360 * 180, 0, 0));
        if(time < 1800 )
          intensity = 1 - (1800 -time) / 1800;
        else
            intensity = 1 - (1800 - time) / 1800 * -1;
        
        RenderSettings.fogColor = Color.Lerp(fognight, fogday, intensity * intensity);

        Sun.intensity = intensity;


    }
}
