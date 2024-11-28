using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 200f; 

    void Update()
    { 
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(movimientoHorizontal * velocidad * Time.deltaTime,0,0);
    }
}
