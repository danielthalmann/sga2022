using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_manager : MonoBehaviour
{
	[SerializeField]
	Transform characterToFollow;
    // Start is called before the first frame update

    public float speed = 0.125f;
    public Vector3 offset;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //        Vector3 desiredPosition = characterToFollow.position + offset;
        //        Vector3 SmoothPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        Cursor.visible = false;
        transform.position = new Vector3(characterToFollow.position.x, characterToFollow.position.y, transform.position.z);
//        transform.position = SmoothPosition;
    }
}
