using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunMusicController : MonoBehaviour
{

    public bool isFinal = false;

    // Start is called before the first frame update
    void Start()
    {
        if (isFinal)
            GameManager.Final();
        else
            GameManager.Starting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
