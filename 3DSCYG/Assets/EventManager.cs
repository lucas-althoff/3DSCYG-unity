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
        if (eventID == 1)
        {
            SceneManager.LoadScene("Missao_Arte_1");
        } else if (eventID == 2) {
            SceneManager.LoadScene("Missao_Padrao_1");
        }
    }
}
