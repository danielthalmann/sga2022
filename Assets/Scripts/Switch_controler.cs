using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Switch_controler : MonoBehaviour
{
    bool switchState = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Switch()
    {
        switchState = !switchState;
        Debug.Log(switchState);
    }


}
