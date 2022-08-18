using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class PlayerController : DamageScript
{

    public Light2D l;

    public float maxLive = 1.0f;

    public float live = 1.0f;
    public float damage = 0.01f;
    public float restore = 0.01f;

    private float intensityMax ;
    private bool restoreDamage = false;

    // Start is called before the first frame update
    void Start()
    {
        live = maxLive;
        intensityMax = l.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        l.intensity = intensityMax * (live / maxLive);

        if (restoreDamage)
            if (live < maxLive)
            {
                live += Time.deltaTime * restore;
                if (live > maxLive)
                {
                    live = maxLive;
                }
            }

        if (live <= 0f)
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }

    }

    public override void ApplyDamage()
    {
        live -= Time.deltaTime * damage;
        restoreDamage = false;
    }

    public override void RestoreDamage()
    {
        restoreDamage = true;
    }
}
