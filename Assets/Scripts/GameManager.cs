using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool passedLevel1 = false;
    public bool passedLevel2 = false;
    public AudioClip AmbiantSound;
    public AudioClip FinalSound;
    public AudioSource audioObject;
   
    // AudioSource
    private static GameManager gameManager;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameManager);
        }
        else
        {
            Destroy(this);
        }
    }

    public static void Starting()
    {
        gameManager.audioObject.clip = gameManager.AmbiantSound;
        gameManager.audioObject.Play();
        gameManager.passedLevel1 = false;
        gameManager.passedLevel2 = false;
    }

    public static void Final()
    {
        gameManager.audioObject.clip = gameManager.FinalSound;
        gameManager.audioObject.Play();
        gameManager.passedLevel1 = false;
        gameManager.passedLevel2 = false;
    }

    public static void SetPassedLevel1(bool value)
    {
        gameManager.passedLevel1 = value;
    }

    public static bool IsPassedLevel1()
    {
        return gameManager.passedLevel1;
    }

    public static void SetPassedLevel2(bool value)
    {
        gameManager.passedLevel2 = value;
    }

    public static bool IsPassedLevel2()
    {
        return gameManager.passedLevel2;
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
