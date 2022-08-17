using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracter_controler : MonoBehaviour
{
	float	moveSpeed = 0;
	Rigidbody2D rigidbody2d;
	[SerializeField]
	float moveMultiplication = 500;
	[SerializeField]
	bool hasToClimb = false;
	private float	climbSpeed = 0;
	private Switch_controler switch_Controler;
    bool switchPress = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
		rigidbody2d.gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = Input.GetAxis("Horizontal") * moveMultiplication * Time.deltaTime;
		if (hasToClimb)
		{
			climbSpeed = Input.GetAxis("Vertical") * moveMultiplication * Time.deltaTime;
		}
		else
			climbSpeed = 0;
		rigidbody2d.velocity = new Vector2(moveSpeed, climbSpeed);
		if (Input.GetButtonDown("Jump") && switch_Controler != null && !switchPress)
        {
			switch_Controler.Switch();
            switchPress = true;
        }
        if (Input.GetButtonUp("Jump"))
        {
            switchPress = false;
        }
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
                rigidbody2d.gravityScale = 1;
                hasToClimb = false;
                break;
            case "Switch":
                switch_Controler = null;
                break;
        }
	}
}
