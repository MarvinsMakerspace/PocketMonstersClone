using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject playerObj;
    public Vector3 teleportPosition;

    public GameController gameController;
    public int fadeSpeed = 5;
    
    private void OnTriggerEnter(Collider other)
    {
        // disable all controls
        // fade to black
        StartCoroutine(gameController.FadeToBlack(true, fadeSpeed));
        // teleport player to given position
        playerObj.transform.position = teleportPosition;
        
        // fade back in
        //StartCoroutine(FadeToBlack(false, fadeSpeed));
        // enable all controls
    }
}
