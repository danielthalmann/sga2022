using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class lightDigDoor1 : MonoBehaviour
{
    public Light2D lightObject = null;
    [SerializeField]
    public bool ForLevel1 = false;
    [SerializeField]
    public bool ForLevel2 = false;
    // Start is called before the first frame update

    void Start()
    {
        lightObject.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (ForLevel1 && GameManager.IsPassedLevel1())
            lightObject.color = Color.green;
        if (ForLevel2 && GameManager.IsPassedLevel2())
            lightObject.color = Color.green;
    }
}
