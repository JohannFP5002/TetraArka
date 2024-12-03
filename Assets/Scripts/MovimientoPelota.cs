using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    [SerializeField]
    GameObject Pelota;
    [SerializeField]
    private Vector3 velocidadInicial;
    private Rigidbody rb;
    private bool BallinMoving;
    public TextMeshProUGUI CantidadVidas;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !BallinMoving)
        {
            Lanzar();
        }
        QuitarVida();
    }
    private void Lanzar()
    {
        transform.parent = null;
        rb.velocity = velocidadInicial;
        BallinMoving = true;
    }
    public void QuitarVida()
    {
        int Vidas = 3;
        if (Pelota)
        {
            Vidas = Vidas - 1;
        }
        CantidadVidas.text = Vidas.ToString();
    }
}
