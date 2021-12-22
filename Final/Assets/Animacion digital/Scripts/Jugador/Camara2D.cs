using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara2D : MonoBehaviour
{
    public GameObject gameObjectSeguir;
    protected float margenX;
    protected float margenY;
    protected float currentVelocityX;
    protected float currentVelocityY;
    // Use this for initialization
    void Start()
    {
        Vector2 vector2min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 vector2max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        margenX = (vector2max.x - vector2min.x) / 4;
        margenY = (vector2max.y - vector2min.y) / 4;
    }

    // Update is called once per frame
    void Update()
    {
        moverCamara();
    }
    void moverCamara()
    {
        Vector2 vector2min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 vector2max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector3 nuevaPosicion = new Vector3();
        //el jugador siempre entre lo límites en el ejeX e ejeY
        //calculo desplazamiento eje x y eje y
        float desplazmientoJugadorX = Mathf.Clamp(gameObjectSeguir.transform.position.x, vector2min.x + margenX, vector2max.x - margenX);
        desplazmientoJugadorX = gameObjectSeguir.transform.position.x - desplazmientoJugadorX;
        float desplazamientoJugadorY = Mathf.Clamp(gameObjectSeguir.transform.position.y, vector2min.y + margenY, vector2max.y - margenY);
        desplazamientoJugadorY = gameObjectSeguir.transform.position.y - desplazamientoJugadorY;
        //para hacer que el movimiento de la camara sea suave
        nuevaPosicion.x = Mathf.SmoothDamp(transform.position.x, transform.position.x + desplazmientoJugadorX, ref currentVelocityX,0.5f);
        nuevaPosicion.y = Mathf.SmoothDamp(transform.position.y, transform.position.y + desplazamientoJugadorY, ref currentVelocityY, 0.5f);
        nuevaPosicion.z = Camera.main.transform.position.z;
        Camera.main.transform.position = nuevaPosicion;
    }
}
   
