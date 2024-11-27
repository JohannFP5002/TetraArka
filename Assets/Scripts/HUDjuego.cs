using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDjuego : MonoBehaviour
{
    [SerializeField]
    TextMeshPro ContadorTiempo, ContadorPuntuacion;
    float Timer = 0;
    [Header("Fila1")]
    public GameObject Bloque11;
    public GameObject Bloque12;
    public GameObject Bloque13;
    public GameObject Bloque14;
    public GameObject Bloque15;
    [Header("Fila2")]
    public GameObject Bloque21;
    public GameObject Bloque22;
    public GameObject Bloque23;
    public GameObject Bloque24;
    public GameObject Bloque25;
    [Header("Fila3")]
    public GameObject Bloque31;
    public GameObject Bloque32;
    public GameObject Bloque33;
    public GameObject Bloque34;
    public GameObject Bloque35;
    [Header("Fila4")]
    public GameObject Bloque41;
    public GameObject Bloque42;
    public GameObject Bloque43;
    public GameObject Bloque44;
    public GameObject Bloque45;
    [Header("Fila5")]
    public GameObject Bloque51;
    public GameObject Bloque52;
    public GameObject Bloque53;
    public GameObject Bloque54;
    public GameObject Bloque55;
    [Header("Fila6")]
    public GameObject Bloque61;
    public GameObject Bloque62;
    public GameObject Bloque63;
    public GameObject Bloque64;
    public GameObject Bloque65;
    void Update()
    {
        
    }
    public void Cronometro()
    {
        Timer = Time.deltaTime;
    }
    public void Puntuacion()
    { 
    
    }

}
