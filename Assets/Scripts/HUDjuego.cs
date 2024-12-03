using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDjuego : MonoBehaviour
{
    
    public TextMeshProUGUI textoCronometro;
    private float tiempoTranscurrido = 0f;
    public bool corriendo = false;
    float Timer;

    private void Start()
    {
        if (textoCronometro == null)
        {
            Debug.Log("TextMeshProUGUI no está asignado.");
        }
    }
    void Update()
    {
        if (corriendo == true)
        {
            tiempoTranscurrido += Time.deltaTime;
        }
        else
        {
            tiempoTranscurrido = tiempoTranscurrido;
        }
        MostrarTiempo();
    }
    
    void MostrarTiempo()
    {
        int minutos = Mathf.FloorToInt(tiempoTranscurrido / 60f);
        int segundos = Mathf.FloorToInt(tiempoTranscurrido % 60f);
        int milisegundos = Mathf.FloorToInt((tiempoTranscurrido * 100f) % 100f);

        textoCronometro.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, milisegundos);
    }
}
