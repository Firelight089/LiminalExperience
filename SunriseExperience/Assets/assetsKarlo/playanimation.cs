using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanimation : MonoBehaviour
{
    // Start is called before the first frame update

    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
