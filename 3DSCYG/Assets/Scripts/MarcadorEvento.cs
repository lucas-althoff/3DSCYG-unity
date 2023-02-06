using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pacotes do mapbox para inserir info de posição do jogador
using Mapbox.Examples;
using Mapbox.Utils;

public class MarcadorEvento : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;
    [SerializeField] float amplitude = 2.0f;
    [SerializeField] float frequency = 0.50f;
    [SerializeField] bool RotacaoZ;

    //[SerializeField] GameObject menuManager;

    LocationStatus playerLocation;
    public Vector2d eventPos; 

    MenuManager menuManager;
    public int eventID;
    EventManager eventManager;
    private int _maxDist;

    // Start is called before the first frame update
    void Start()
    {                
        menuManager = GameObject.Find("TelasMissao").GetComponent<MenuManager>();
        eventManager = GameObject.Find("EventManager").GetComponent<EventManager>();
        _maxDist = eventManager.maxDist;
    }

    // Update is called once per frame
    void Update()
    {
        AnimarPOI();
    }

    void AnimarPOI(){
        if (RotacaoZ)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x,(Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude+10),transform.position.z);
        }
        else
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x,(Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude+10),transform.position.z);
        }
    }

    void OnMouseDown() {
        playerLocation = GameObject.Find("PlayerView").GetComponent<LocationStatus>();
        //Debug.Log("Player (Lat, Lon) = " + playerLocation.GetLocationLat() + " , " + playerLocation.GetLocationLon());
        //Debug.Log("Event (Lat, Lon) = " + eventPos[0] + " , " + eventPos[1]);

        var currentPlayerLocation = new GeoCoordinatePortable.GeoCoordinate(playerLocation.GetLocationLat(),playerLocation.GetLocationLon());
        var eventLocation = new GeoCoordinatePortable.GeoCoordinate(eventPos[0],eventPos[1]);
        var distance = currentPlayerLocation.GetDistanceTo(eventLocation); 

        if (distance < _maxDist)
        {
            menuManager.LimparManager();
            menuManager.AbrirMissaoEventoPerto(eventID);        
        }
        else
        {
            menuManager.LimparManager();
            menuManager.AbrirMissaoEventoLonge();
        }
    }
}
