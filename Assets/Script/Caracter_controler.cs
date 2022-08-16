using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracter_controler : MonoBehaviour
{
	float	moveSpeed = 0;
	// float	absmoveSpeed = 0;
	Rigidbody2D rigidbody2d;
	[SerializeField]
	float moveMultiplication = 5;
	[SerializeField]
	float jumpForce = 100;
	bool hasToJump = false;
	// private SpriteRenderer _renderer;
	// Animator	animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
		//  _renderer = GetComponent<SpriteRenderer>();
		// animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = Input.GetAxis("Horizontal") * moveMultiplication;
		if (Input.GetButtonDown("Jump"))
		{
			hasToJump = true;
		}
        // if (Input.GetAxisRaw("Horizontal") > 0)
        // {
		// 	absmoveSpeed = moveSpeed;
        //     _renderer.flipX = false;
        // }
        // else if (Input.GetAxisRaw("Horizontal") < 0)
        // {
		// 	absmoveSpeed = - moveSpeed;
        //     _renderer.flipX = true;
        // }
    }

	private void FixedUpdate()
	{
		rigidbody2d.velocity = new Vector2(moveSpeed, rigidbody2d.velocity.y);
		// animator.SetFloat("running", absmoveSpeed);
		if (hasToJump)
		{
			rigidbody2d.AddForce(new Vector2(0, jumpForce));
			// animator.SetTrigger("JumpTrigger");
			hasToJump = false;
		}
	}
}
