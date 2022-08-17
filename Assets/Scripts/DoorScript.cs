using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : ToggleScript
{

    public bool Open = false;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Open)
            anim.SetBool("Open", true);
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
