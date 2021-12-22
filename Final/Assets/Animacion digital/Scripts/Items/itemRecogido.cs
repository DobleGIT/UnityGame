using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRecogido : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jugador")) //comprobamos que la colision que ha ocurrido sea de nuestro jugador
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            Destroy(gameObject, 0.5f); ;
        }
    }

}
