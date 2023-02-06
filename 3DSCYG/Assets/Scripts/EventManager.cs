using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    public int maxDist = 70;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateEvent(int eventID)
    {
        
        switch (eventID)
        {
            case 1:
                //Incluir tipo de missao
            case 2:
                //Incluir tipo de missao
            case 3:
                //Incluir tipo de missao
            default:
                SceneManager.LoadScene("IniciarMissaoSeletiva");
                break;
        }
        
        //if (eventID == 1)
        //{
        //    SceneManager.LoadScene("IniciarMissaoSeletiva");
        //} else {
            //SceneManager.LoadScene("IniciarMissaoPadrao");
            //SceneManager.LoadScene("Missao_Padrao_1");
        //}
    }
}
