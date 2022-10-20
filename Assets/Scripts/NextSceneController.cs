using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneController : MonoBehaviour
{
    public string sceneName;
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trig");
        if (sceneName != "")
            LoadNextScene(sceneName);
    }

    public void LoadNextScene(string name)
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
