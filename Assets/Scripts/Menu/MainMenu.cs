using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    /**
     * D�marre la scene suivante dans unity
     */
    public void PlayGame()
    {
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

}
