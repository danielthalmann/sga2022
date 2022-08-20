using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaDoorOpen : MonoBehaviour
{
    public bool AllLeversOk = false;

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
        if (GameManager.IsPassedLevel1() && GameManager.IsPassedLevel2())
        {
            col.isTrigger = true;
        }


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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        switch (collider.tag)
        {
            case "Player":
                //if (GameManager.IsPassedLevel1() && GameManager.IsPassedLevel2())
                    AllLeversOk = true;
                break;

        }
    }
}
