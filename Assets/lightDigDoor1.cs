using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightDigDoor1 : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light;
    [SerializeField]
    public bool lock1OK = false;
    // Start is called before the first frame update
    void Start()
    {
        light.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (lock1OK)
            light.color = Color.green;
    }
}
