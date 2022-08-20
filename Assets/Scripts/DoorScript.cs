using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : ToggleScript
{

    public bool Open;

    public Animator anim;   
    
    
    private AudioSource sound;
	private Collider2D col;


    // Start is called before the first frame update
    void Start()
    {

        col = GetComponent<Collider2D>();
        sound = GetComponent<AudioSource>();
        if (sound)
            sound.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Open) {

            if (!anim.GetBool("Open"))
                PlaySound();

            anim.SetBool("Open", true);
            col.enabled = false;
		}
        else
        {
            if (anim.GetBool("Open"))
                PlaySound();

            col.enabled = true;
            if (anim.GetBool("Open"))
                anim.SetBool("Open", false);
        }
    }

    private void PlaySound()
    {

            if (sound)
                sound.Play();

    }

    public override void ChangeState()
    {
        Open = !Open;
    }
}
