using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer: MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            anim.SetBool("Left", true);
        }
        else if(Input.GetKeyUp("a"))
        {
            anim.SetBool("Left", false);
        }

        if (Input.GetKeyDown("d"))
        {
            anim.SetBool("Right", true);
        }
        else if (Input.GetKeyUp("d"))
        {
            anim.SetBool("Right", false);
        }
    }
}
