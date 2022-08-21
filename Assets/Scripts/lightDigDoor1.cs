using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightDigDoor1 : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light;
    [SerializeField]
    public bool ForLevel1 = false;
    [SerializeField]
    public bool ForLevel2 = false;
    // Start is called before the first frame update

    void Start()
    {
        light.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (ForLevel1 && GameManager.IsPassedLevel1())
            light.color = Color.green;
        if (ForLevel2 && GameManager.IsPassedLevel2())
            light.color = Color.green;
    }
}
