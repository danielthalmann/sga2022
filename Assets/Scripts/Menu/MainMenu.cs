using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator transition;

    void Start()
    {
        Cursor.visible = true;
    }

    /**
     * D�marre la scene suivante dans unity
     */
    public void PlayGame()
    {
        //SceneManager.LoadScene("Final");
        LoadNextScene("tutorial");
    }


    /**
     * Quit l'application. En mode de developpement, la fonction Application.Quit n'effectue aucune action
     * On affiche donc quit dans la console
     */
    public void QuitGame()
    {

        Debug.Log("Quit");
        Application.Quit();

    }


    /**
     * D�marre la scene suivante dans unity
     */
    public void Credits()
    {
        LoadNextScene("Credits");
    }


    /**
     * D�marre la scene suivante dans unity
     */
    public void Menu()
    {
        Cursor.visible = true;
        LoadNextScene("Menu");
    }

    protected void LoadNextScene(string name)
    {
        StartCoroutine(EnumLoad(name));
    }

    IEnumerator EnumLoad(string name) 
    {
        // start transition
        transition.SetTrigger("Start");
        Debug.Log("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(name);
    }

}
