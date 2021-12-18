using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fade2Black : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play("Fade2Black");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
