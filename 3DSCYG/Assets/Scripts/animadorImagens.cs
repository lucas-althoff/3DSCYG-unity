using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animadorImagens : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;
    [SerializeField] bool RotacaoZ;
    //[SerializeField] float amplitude = 2.0f;
    //[SerializeField] float frequency = 0.50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RotacaoZ)
        {
            rotacionarEixoZ();
        }
        else
        {
            rotacionarEixoY();
        }
    }

    void rotacionarEixoY()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void rotacionarEixoZ()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}