using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Cancel")) quitGame();
    }

    public void changeScene(string sceneName)
    {
        StartCoroutine(Espera(0.5f));
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void quitGame()
    {
        StartCoroutine(Espera(0.5f));
        Application.Quit();
    }

    IEnumerator Espera(float tempo)
    {
        yield return new WaitForSeconds(tempo);
    }
}