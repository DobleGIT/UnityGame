using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public static bool tocaSuelo;

    private void OnTriggerEnter2D(Collider2D collision) //si nuestro personaje toca suelo se pone en true
    {
        if(collision.CompareTag("estructura")) //comprobamos que la colision que ha ocurrido sea de nuestro jugador
        {
           tocaSuelo = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("estructura")) //comprobamos que la colision que ha ocurrido sea de nuestro jugador
        {
            tocaSuelo = false;
        }
    }
}
