using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightController : ToggleScript
{

    public DamageScript dam;

    public Light2D light = null;

    public bool takeDamage;
    public bool lightOn;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (light)
            light.enabled = lightOn;
        if (!lightOn)
        {
            dam.ApplyDamage();
        } else
        {
            dam.RestoreDamage();
        }
    }

    public override void ChangeState()
    {
        takeDamage = !takeDamage;
        lightOn = !lightOn;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

    }
    private void OnTriggerExit2D(Collider2D collider)
    {

    }
}
