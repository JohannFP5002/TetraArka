using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VidasBloques : MonoBehaviour
{
    public TextMeshProUGUI Puntuacion;
    MovimientoPelota Pelota;
    [SerializeField] 
    GameObject bloques;
    [SerializeField]
    public int BloquesVidas = 1;
    [SerializeField]
    public int PuntuacionBloque = 100;
    private void Update()
    {
        EliminarBloques();
    }
    public void EliminarBloques()
    {
        if (Pelota)
        {
            BloquesVidas = BloquesVidas - 1;
            if (BloquesVidas <= 0)
            {
                bloques.SetActive(false);
            }
        }
        Puntuacion.text = PuntuacionBloque.ToString();
    }
}
