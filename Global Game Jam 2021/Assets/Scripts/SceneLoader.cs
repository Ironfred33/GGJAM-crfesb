using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Load next level
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Load first level
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
