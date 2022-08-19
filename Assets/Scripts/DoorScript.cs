using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : ToggleScript
{

    public bool Open;

    public Animator anim;    
	private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {

        col = GetComponent<Collider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Open) {
            anim.SetBool("Open", true);
            col.enabled = false;
		}
        else
        {
            col.enabled = true;
            if (anim.GetBool("Open"))
                anim.SetBool("Open", false);
        }
    }

   public override void ChangeState()
    {
        Open = !Open;
    }
}
