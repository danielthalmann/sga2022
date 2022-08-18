using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_manager : MonoBehaviour
{
	[SerializeField]
	Transform characterToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(characterToFollow.position.x, characterToFollow.position.y, transform.position.z);
    }
}
