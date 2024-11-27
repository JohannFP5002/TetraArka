using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    public float VelocidadPlayer;
    
    void Start()
    {
        
    }

    public void MovimientoPlayer()
    {
        if (Player == true){
            if (Input.GetKey(KeyCode.A))
            {
                Player.transform.position += Vector3.right * Time.deltaTime * VelocidadPlayer;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Player.transform.position += Vector3.left * Time.deltaTime * VelocidadPlayer;
            }
        }
    }
}
