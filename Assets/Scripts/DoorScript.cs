using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : ToggleScript
{

    public bool Open = false;

    private Animator anim;    
	private Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        collider = GetComponent<Collider>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Open) {
            anim.SetBool("Open", true);
            collider.enabled = false;
		}
        else
        {
            collider.enabled = true;
            if (anim.GetBool("Open"))
                anim.SetBool("Open", false);
        }
    }

   public override void ChangeState()
    {
        Open = !Open;
    }
}
