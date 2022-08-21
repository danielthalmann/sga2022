using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TriggerLightController : MonoBehaviour
{
    [Range(0f, 1.0f)]
    public float MinimalIntensity = 0f;
    [Range(0f, 1.0f)]
    public float MaximalIntensity = 1f;


    [Range(0.1f, 2.0f)]
    public float IntensitySpeedIn = 0.8f;
    [Range(0.1f, 2.0f)]
    public float IntensitySpeedOut = 0.4f;
    public Light2D lightObject;
    public bool lightOn;

    private float intensity;

    // Start is called before the first frame update
    void Start()
    {
        if (lightOn)
        {
            lightObject.intensity = 1.0f;
            intensity = MaximalIntensity;
        }
        else
        {
            lightObject.intensity = 0.0f;
            intensity = MinimalIntensity;
        }

        }

    // Update is called once per frame
    void Update()
    {
        if (lightOn)
        {
            if (lightObject.intensity < MaximalIntensity)
            {
                intensity += Time.deltaTime * IntensitySpeedIn;
            }
        }
        else
        {
            if (lightObject.intensity > MinimalIntensity)
            {
                intensity -= Time.deltaTime * IntensitySpeedOut;
            }
        }

        lightObject.intensity = intensity;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            lightOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
 
        if (collision.tag == "Player")
            lightOn = false;

    }

}
