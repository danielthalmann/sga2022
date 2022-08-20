using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassedLevelController : MonoBehaviour
{
    public bool Level1;
    public bool Level2;
    // Start is called before the first frame update
    void Start()
    {
        if (Level1)
          GameManager.SetPassedLevel1(true);
        if (Level2)
          GameManager.SetPassedLevel2(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
