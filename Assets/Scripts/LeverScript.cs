using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : ToggleScript
{
    public bool Open = false;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Open)
        {
            anim.SetBool("Open", true);
        }
        else
        {
            if (anim.GetBool("Open"))
                anim.SetBool("Open", false);
        }
    }

    public override void ChangeState()
    {
        Open = !Open;
    }
}
