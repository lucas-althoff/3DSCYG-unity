using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animadorImagens : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;
    //[SerializeField] float amplitude = 2.0f;
    //[SerializeField] float frequency = 0.50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animarImagem();
    }

    void animarImagem()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}