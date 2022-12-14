using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracter_controler : MonoBehaviour
{
	float	moveSpeed = 0;
    float absmoveSpeed = 0;
    Rigidbody2D rigidbody2d;
	[SerializeField]
	float moveMultiplication = 10;
	[SerializeField]
	bool hasToClimb = false;
	private float	climbSpeed = 0;
	private Switch_controler switch_Controler;
    bool switchPress = false;
    private SpriteRenderer _renderer;
    Animator animator;

    public AudioClip[] soundWalkClips = new AudioClip[0];
    public AudioClip[] soundLadderClips = new AudioClip[0];
    private AudioSource sound;
    public float AudioWalkSpeed = .5f;
    public float AudioLadderSpeed = .5f;
    private float LastTimeAudio = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
		rigidbody2d.gravityScale = 30;
        _renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = Input.GetAxis("Horizontal") * moveMultiplication;

        LastTimeAudio += Time.deltaTime;

        if (hasToClimb)
        {
            climbSpeed = Input.GetAxis("Vertical") * (moveMultiplication/2);
            if (climbSpeed != 0)
            {
                animator.SetBool("ladder", hasToClimb);

                if (climbSpeed != 0.0f)
                    PlayLadderSound();        
            }
            animator.SetInteger("climb", climbSpeed == 0 ? 0 : 1);

        }

        else
        {
            climbSpeed = 0;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            PlayWalkSound();
            animator.SetInteger("walk", 1); 
            absmoveSpeed = moveSpeed;
            _renderer.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            PlayWalkSound();
            animator.SetInteger("walk", 1);
            absmoveSpeed = moveSpeed;
            _renderer.flipX = true;
        }
        else
            animator.SetInteger("walk", 0);

        if (Input.GetButtonDown("Jump") && switch_Controler != null && !switchPress)
        {


            switch_Controler.Switch();
            switchPress = true;
        }
        if (switchPress && !Input.GetButtonUp("Jump"))
        {
            switchPress = false;
        }
        
    }

    public void PlayWalkSound()
    {
        if (sound)
        {
            if (LastTimeAudio > AudioWalkSpeed)
            {
                int idx = Random.Range(0, soundWalkClips.Length - 1);
                sound.Stop();
                sound.clip = soundWalkClips[idx];
                sound.Play();
                LastTimeAudio = 0;
            }
        }
    }

    public void PlayLadderSound()
    {
        if (sound)
        {
            if (LastTimeAudio > AudioLadderSpeed)
            {
                int idx = Random.Range(0, soundLadderClips.Length - 1);
                sound.Stop();
                sound.clip = soundLadderClips[idx];
                sound.Play();
                LastTimeAudio = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        rigidbody2d.velocity = new Vector2(moveSpeed, climbSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
	{
        switch (collider.tag){
		    case "ladder":
                rigidbody2d.gravityScale = 0;
                hasToClimb = true;
		    	break;
            case "Switch":
		    	switch_Controler = collider.gameObject.GetComponent<Switch_controler>();
                break;
        }
    }

	private void OnTriggerExit2D(Collider2D collider)
	{
        switch (collider.tag)
        {
            case "ladder":
                rigidbody2d.gravityScale = 30;
                hasToClimb = false;
                animator.SetBool("ladder", hasToClimb);
                break;
            case "Switch":
                switch_Controler = null;
                break;
        }
	}
}
