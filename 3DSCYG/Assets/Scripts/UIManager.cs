
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //Screen object variables
    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject PlayerViewUI;
    public GameObject TelaEntradaUI;
    public GameObject MenuUI;
    public GameObject MissoesUI;
    public GameObject PerfilUI;
    public GameObject userDataUI;
    public GameObject scoreboardUI;
    public GameObject MissaoManager;

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
        MissaoManager.SetActive(true);
        registerUI.SetActive(false);
        PlayerViewUI.SetActive(false);
        TelaEntradaUI.SetActive(false);
        MenuUI.SetActive(false);
        MissoesUI.SetActive(false);
        PerfilUI.SetActive(false);
        userDataUI.SetActive(false);
        scoreboardUI.SetActive(false);
    }

    //Functions to change the login screen UI

    public void ClearScreen() //Turn off all screens
    {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        PlayerViewUI.SetActive(false);
        TelaEntradaUI.SetActive(false);
        MenuUI.SetActive(false);
        MissoesUI.SetActive(false);
        PerfilUI.SetActive(false);
        userDataUI.SetActive(false);
        scoreboardUI.SetActive(false);
        MissaoManager.SetActive(true);
    }

  public void ClearScreenPopUp() //Turn off all screens except PlayerView HUD
    {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        TelaEntradaUI.SetActive(false);
        MenuUI.SetActive(false);
        MissoesUI.SetActive(false);
        PerfilUI.SetActive(false);
        userDataUI.SetActive(false);
        scoreboardUI.SetActive(false);
        MissaoManager.SetActive(true);
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
    public void PlayerViewScreen() //Back button
    {
        ClearScreen();
        PlayerViewUI.SetActive(true);
    }

    public void TelaEntradaScreen() //Back button
    {
        ClearScreen();
        TelaEntradaUI.SetActive(true);
    }

    public void PerfilScreen() //Back button
    {
        ClearScreen();
        PerfilUI.SetActive(true);
    }

    public void MissoesScreen() //Back button
    {
        ClearScreenPopUp();
        MissoesUI.SetActive(true);
    }
    
    public void MenuScreen() //Back button
    {
        ClearScreen();
        MenuUI.SetActive(true);
    }
    
    
    public void UserDataScreen() //Logged in
    {
        ClearScreen();
        userDataUI.SetActive(true);
    }

    public void ScoreboardScreen() //Scoreboard button
    {
        ClearScreen();
        scoreboardUI.SetActive(true);
    }
    
    public void PlayerViewActivate() //Scoreboard button
    {
        ClearScreen();
        PlayerViewUI.SetActive(true);
    }

}
