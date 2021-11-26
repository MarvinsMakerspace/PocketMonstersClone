using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class GameController : MonoBehaviour
{
    public GameObject blackOut;
    public ThirdPersonController playerScript; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.Grounded && blackOut.GetComponent<Image>().color.a >= 1) {
            StartCoroutine(FadeToBlack(false, 5));
        }
    }

    public IEnumerator FadeToBlack(bool fadeToBlack = true, int fadeSpeed = 5)
    {
        Color objectColor = blackOut.GetComponent<Image>().color;
        float fadeAmount;

        if(fadeToBlack) {
            Debug.Log("FadeOut");
            while (blackOut.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOut.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        } else {
            Debug.Log("FadeIn");
            while (blackOut.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOut.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
}
