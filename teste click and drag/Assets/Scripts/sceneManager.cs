using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

    void Update()
    {
        if (Input.GetButtonDown("Cancel")) quitGame();
    }

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
