using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaDoorOpen : MonoBehaviour
{
    public bool AllLeversOk = false;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (AllLeversOk)
        {
            anim.SetBool("AllLeversOk", true);
        }
        else
        {
            if (anim.GetBool("AllLeversOk"))
                anim.SetBool("AllLeversOk", false);
        }
    }
}
