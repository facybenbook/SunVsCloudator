﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplayButton : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame

    public void replayGame(){
        LoadScript.nextSceneName = "GameScene";
        SceneManager.LoadScene("LoadingScene");
    }

    public void GoToMainMenu(){
        LoadScript.nextSceneName = "MainMenuScene";
        SceneManager.LoadScene("LoadingScene");
    }


}