using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool passedLevel1 = true;

    private static GameManager gameManager;

    private void Awake()
    {
        if (gameManager != null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameManager);
        }
        else
        {
            Destroy(this);
        }
    }

    public static void SetPassedLevel1(bool value)
    {
        gameManager.passedLevel1 = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
