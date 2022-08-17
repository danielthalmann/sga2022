using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Switch_controler : MonoBehaviour
{
    bool switchState = false;
    public ToggleScript[] toggleScripts = new ToggleScript[0];


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Switch()
    {
        switchState = !switchState;
        Debug.Log(switchState);
        for (int i = toggleScripts.Length - 1; i >= 0; i--)
            toggleScripts[i].ChangeState();
    }


}
