using System.Collections;
using Liminal.SDK.Core;
using Liminal.SDK.VR.Avatars;
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
