using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ExitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void NewGame() {
        Debug.Log("Starting Game...");
        SceneManager.LoadScene(1);
    }
}
