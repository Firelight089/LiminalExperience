using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject SunPosition;

    void Start()
    {
        Invoke("EndGame", 180);
    }

    private void EndGame()
    {
        Application.Quit();
    }
}
