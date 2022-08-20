using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveEndController : MonoBehaviour
{


    /**
     * D�marre la scene suivante dans unity
     */
    public void PlayGame()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Esc"))
        {

        }
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
