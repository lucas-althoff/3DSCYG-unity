using System.Collections;
using System.Collections;
using UnityEngine;

public class PersonagemManager : MonoBehaviour
{
    public static PersonagemManager instance;
    
    //Screen object variables
    public GameObject Personagem1;
    public GameObject ImagemPersonagem1;
    public GameObject Personagem2;
    public GameObject ImagemPersonagem2;
    public GameObject Personagem3;
    public GameObject ImagemPersonagem3;
    public GameObject Personagem4;
    public GameObject ImagemPersonagem4;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            PersonagemInicial();
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }
    
    public void PersonagemInicial() //Turn off all screens
    {
        Personagem1.SetActive(true);
        ImagemPersonagem1.SetActive(true);
        Personagem2.SetActive(false);
        ImagemPersonagem2.SetActive(false);
        Personagem3.SetActive(false);
        ImagemPersonagem3.SetActive(false);
        Personagem4.SetActive(false);
        ImagemPersonagem4.SetActive(false);
    }

     public void AtivarPersonagem1() //Turn off all screens
    {
        Personagem1.SetActive(true);
        ImagemPersonagem1.SetActive(true);
        Personagem2.SetActive(false);
        ImagemPersonagem2.SetActive(false);
        Personagem3.SetActive(false);
        ImagemPersonagem3.SetActive(false);
        Personagem4.SetActive(false);
        ImagemPersonagem4.SetActive(false);
    }

     public void AtivarPersonagem2() //Turn off all screens
    {
        Personagem1.SetActive(false);
        ImagemPersonagem1.SetActive(false);
        Personagem2.SetActive(true);
        ImagemPersonagem2.SetActive(true);
        Personagem3.SetActive(false);
        ImagemPersonagem3.SetActive(false);
        Personagem4.SetActive(false);
        ImagemPersonagem4.SetActive(false);
    }

     public void AtivarPersonagem3() //Turn off all screens
    {
        Personagem1.SetActive(false);
        ImagemPersonagem1.SetActive(false);
        Personagem2.SetActive(false);
        ImagemPersonagem2.SetActive(false);
        Personagem3.SetActive(true);
        ImagemPersonagem3.SetActive(true);
        Personagem4.SetActive(false);
        ImagemPersonagem4.SetActive(false);
    }
    
    public void AtivarPersonagem4() //Turn off all screens
    {
        Personagem1.SetActive(false);
        ImagemPersonagem1.SetActive(false);
        Personagem2.SetActive(false);
        ImagemPersonagem2.SetActive(false);
        Personagem3.SetActive(false);
        ImagemPersonagem3.SetActive(false);
        Personagem4.SetActive(true);
        ImagemPersonagem4.SetActive(true);
    }
}
