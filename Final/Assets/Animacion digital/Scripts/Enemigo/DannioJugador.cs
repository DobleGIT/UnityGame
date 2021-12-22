using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DannioJugador : MonoBehaviour
{
    public AudioSource audioMuerte;


    public Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.CompareTag("Jugador"))
        {
            collision.transform.GetComponent<Respawn>().MurioJugador(); //llamamos a la funcion murioJugador para hacer el respawn y la animación
        }
    }
    

}
