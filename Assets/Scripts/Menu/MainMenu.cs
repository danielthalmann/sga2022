using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
        SceneManager.LoadScene("tutorial");
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
        SceneManager.LoadScene("Credits");
    }


    /**
     * D�marre la scene suivante dans unity
     */
    public void Menu()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("Menu");
    }

}
