using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
 
public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject MissaoEventoPertoUI;
    [SerializeField] private GameObject MissaoEventoLongeUI;
    [SerializeField] public GameObject MissaoManager;
    [SerializeField] private EventManager eventManager;
   
    int tempEvent;
    // void Update()
    // {
    //     if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
    //     {
    //         this.gameObject.SetActive(ClickingSelfOrChild());
    //     }
    // }

    // private bool ClickingSelfOrChild()
    // {
    //     RectTransform[] rectTransforms = GetComponentsInChildren<RectTransform>();
    //     foreach(RectTransform rectTransform in rectTransforms)
    //     {
    //         if (EventSystem.current.currentSelectedGameObject == rectTransform.gameObject)
    //         {
    //             isUIPanelActive = true;
    //             return true;
    //         };
    //     }
    //     isUIPanelActive = false;
    //     return false;
    // }
    // void Start() {
    //     MissaoManager.SetActive(false);
    // }

    public void LimparManager()//fechar 
    {
        MissaoManager.SetActive(false);
    }

    public void AbrirMissaoEventoLonge()//Abrir missao apos clicar em uma POI 
    {
        if (MissaoManager.activeSelf == false)
        {
            MissaoManager.SetActive(true);
            if (MissaoEventoPertoUI.activeSelf == false & MissaoEventoPertoUI.activeSelf == false)
            { 
                MissaoEventoLongeUI.SetActive(true);
            }
        }
        if (MissaoEventoPertoUI.activeSelf == false & MissaoEventoPertoUI.activeSelf == false)
        { 
            MissaoEventoLongeUI.SetActive(true);
        }
    }

    public void AbrirMissaoEventoPerto(int eventID)//Abrir missao apos clicar em uma POI
    {
        tempEvent = eventID; 
        if (MissaoManager.activeSelf == false)
        {
            MissaoManager.SetActive(true);
            if (MissaoEventoPertoUI.activeSelf == false & MissaoEventoPertoUI.activeSelf == false)
            { 
                MissaoEventoPertoUI.SetActive(true);
            }
        }
        else if (MissaoEventoPertoUI.activeSelf == false & MissaoEventoPertoUI.activeSelf == false)
        { 
            MissaoEventoPertoUI.SetActive(true);
        }
    }

    public void BotaoFecharTela() //Botao voltar
    {
        if (MissaoEventoPertoUI.activeSelf == true)
        {
            MissaoEventoPertoUI.SetActive(false);
            MissaoManager.SetActive(false);
        }
        if (MissaoEventoLongeUI.activeSelf == true)
        {
            MissaoEventoLongeUI.SetActive(false);
            MissaoManager.SetActive(false);
        }
        
    }

    public void OnBotaoMissao()
    {
        Debug.Log("Evento: " + tempEvent);
        eventManager.ActivateEvent(tempEvent);
    } 

}