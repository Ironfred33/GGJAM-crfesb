﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    /*
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    */
    // Load next level
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    
    // Bei Respawn
    public void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }
}
