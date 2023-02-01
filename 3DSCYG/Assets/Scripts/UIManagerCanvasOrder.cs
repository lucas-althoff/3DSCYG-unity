using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerCanvasOrder : MonoBehaviour
{
    public static UIManagerCanvasOrder instance;

    //Screen object variables
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public GameObject Canvas4;

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
        Canvas1.SetActive(true);
        Canvas2.SetActive(false);
        Canvas3.SetActive(false);
        Canvas4.SetActive(false);
    }

    public void PushCanvas2() //Back button
    {
        Canvas1.SetActive(false);
        Canvas2.SetActive(true);
    }

    public void PushCanvas3() //Back button
    {
        Canvas2.SetActive(false);
        Canvas3.SetActive(true);
    }

    public void PushCanvas4() //Back button
    {
        Canvas3.SetActive(false);
        Canvas4.SetActive(true);
    }

}