using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerAutenticacao : MonoBehaviour
{
    public static UIManagerAutenticacao instance;

    //Screen object variables
    public GameObject loginUI;
    public GameObject registerUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            StartScreen();
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void StartScreen() //Turn off all screens
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
        //PlayerViewUI.SetActive(false);
    }

    //Functions to change the login screen UI

    public void ClearScreen() //Turn off all screens
    {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        //PlayerViewUI.SetActive(false);
    }

    public void LoginScreen() //Back button
    {
        ClearScreen();
        loginUI.SetActive(true);
    }
    public void RegisterScreen() // Regester button
    {
        ClearScreen();
        registerUI.SetActive(true);
    }
    public void LoadPlayerView() //Back button
    {
        SceneManager.LoadScene("PlayerView");
    }
}
