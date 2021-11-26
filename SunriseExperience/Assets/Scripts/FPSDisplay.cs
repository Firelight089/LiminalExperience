using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FPSDisplay : MonoBehaviour
{
    public Text fpsText;
    public float refreshTime = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateFPS", refreshTime, 1);
    }

    // Update is called once per frame
    void UpdateFPS()
    {
        float fps = Mathf.RoundToInt(1 / Time.unscaledDeltaTime);
        fpsText.text = fps.ToString();
    }
}
