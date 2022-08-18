using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Switch_controler : MonoBehaviour
{
    bool switchState = false;

    public ToggleScript[] toggleScripts = new ToggleScript[0];
    public bool backToDefault = false;
    public float timeBack = 0;

    private bool fallback = false;
    private float timer = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Start is called before the first frame update
    void Update()
    {
        if (fallback)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
                Switch();
        }

    }

    // Update is called once per frame
    public void Switch()
    {
        switchState = !switchState;
        Debug.Log(switchState);
        for (int i = toggleScripts.Length - 1; i >= 0; i--)
            toggleScripts[i].ChangeState();
        if (backToDefault && fallback == false)
        {
            fallback = true;
            timer = timeBack;
        } else
        {
            fallback = false;
        }


    }


}
