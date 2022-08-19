using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightController : ToggleScript
{

    public DamageScript dam  = null;

    public Light2D light = null;

    public bool lightOn;

    private bool takeDamage = false;
    private bool damageZone = false;
    private bool releaseDamage = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (light)
            light.enabled = lightOn;
        // on effectue le traitement des domages seulement si on a un élément 
        // de configuré
        if (dam)
        {
            if (!lightOn && damageZone)
            {
                dam.ApplyDamage();
                releaseDamage = false;
            }
            else
            {
                if (!releaseDamage)
                {
                    dam.RestoreDamage();
                    releaseDamage = true;
                }
            }
        }
  
    }

    public override void ChangeState()
    {
        takeDamage = !takeDamage;
        lightOn = !lightOn;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        damageZone = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        damageZone = false;
    }

}
