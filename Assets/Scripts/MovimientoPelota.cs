using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocidadInicial;
    private Rigidbody rb;
    private bool BallinMoving;

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
    }
    private void Lanzar()
    {
        transform.parent = null;
        rb.velocity = velocidadInicial;
        BallinMoving = true;
    }
}
