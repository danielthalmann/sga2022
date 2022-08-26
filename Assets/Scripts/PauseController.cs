using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public bool IsPaused;
    public GameObject PauseMenu;

    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPaused)
        {
            PauseMenu.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if ( Input.GetKeyDown(KeyCode.Escape ) )
        {
            IsPaused = !IsPaused;
        }

    }

    public void Resume()
    {
        IsPaused = false;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    
    
}
