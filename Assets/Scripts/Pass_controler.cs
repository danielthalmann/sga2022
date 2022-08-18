using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass_controler : ToggleScript
{
    public bool Open = false;
    private SpriteRenderer spriteRendererpass;

    // Start is called before the first frame update
    void Start()
    {
        spriteRendererpass = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void ChangeState()
    {

    }
}
