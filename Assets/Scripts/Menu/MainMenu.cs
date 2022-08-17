using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /**
     * Démarre la scene suivante dans unity
     */
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

}
