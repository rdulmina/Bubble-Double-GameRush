using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBlast : MonoBehaviour
{
    public Animator anim;
    public KeyCode pops;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pops)) {
            anim.SetTrigger("onClickPop");
        }
    }
}
