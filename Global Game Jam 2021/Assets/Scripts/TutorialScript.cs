using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutText;

    void Start()
    {
        StartCoroutine(displayText());
    }


    private IEnumerator displayText()
    {
        tutText.SetActive(true);

        yield return new WaitForSeconds(5);

        tutText.SetActive(false);
    }
}
