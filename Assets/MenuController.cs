using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void ExitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
