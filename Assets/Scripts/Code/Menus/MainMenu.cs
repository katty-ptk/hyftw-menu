﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    public void StartGame() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex - 1 );
    }

    public void QuitGame() {
        Debug.Log("quitting game");
        Application.Quit();
    }

}
