using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class muerteCaida : MonoBehaviour
{
    public float fuerzaSalto = 2.5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Jugador"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * fuerzaSalto);
            Debug.Log("danio");
            collision.transform.GetComponent<Respawn>().MurioJugador(); //llamamos a la funcion murioJugador para hacer el respawn y la animación
        }
    }
}
