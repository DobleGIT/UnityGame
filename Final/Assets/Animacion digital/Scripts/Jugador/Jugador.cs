using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //lo utilizamos para el sonido

public class Jugador : MonoBehaviour
{
    public AudioSource audioSalto;

    public float velocidad = 2f;
    public float salto = 4f;
    public float velocidadDobleSalto = 3f;
    bool dobleSalto = false;

    protected Rigidbody2D rigidBody2D;
    public SpriteRenderer spriteRenderer; //utilizado para girar el personaje
    public Animator animator; //referencia a las animaciones


    // Use this for initialization
    void Start()
    {

        rigidBody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) //si pulsamos espacio y esta en el suelo
        {

            if (Suelo.tocaSuelo==true)
            {
                dobleSalto = true;
                rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, salto);
                audioSalto.Play(); //reproducimos el sonido de saltar
            }
            else if(Input.GetKeyDown("space"))
            {
                /*if(dobleSalto ==true)
                {
                    rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, velocidadDobleSalto);
                    dobleSalto = false;
                    audioSalto.Play(); //reproducimos el sonido de saltar
                    //spriteRenderer.flipY = true; 

                }*/
            }
            //spriteRenderer.flipY = false;

        }
        if (Suelo.tocaSuelo == false) //cuando no está tocando suelo se activa la animacion de saltar
        {

            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        else
        {
            animator.SetBool("Jump", false);

        }
    }
    void FixedUpdate()
    {

        animator.SetBool("Hurt", false);

        if ((Input.GetKey("d")) || (Input.GetKey("right")))
        {
            
            rigidBody2D.velocity = new Vector2(velocidad, rigidBody2D.velocity.y);
            spriteRenderer.flipX = false; // esto hace que al moverse a la derecha mire hacia la derecha
            animator.SetBool("Run", true); //hacemos que se active la animacion de correr

        }
        else if ((Input.GetKey("a")) || (Input.GetKey("left")))
        {
            rigidBody2D.velocity = new Vector2(-velocidad, rigidBody2D.velocity.y);
            spriteRenderer.flipX = true; //cuando le damos a la a el personaje mira a la izquierda
            animator.SetBool("Run", true); //hacemos que se active la animacion de correr
        }
        else
        {
            rigidBody2D.velocity = new Vector2(0, rigidBody2D.velocity.y);
            animator.SetBool("Run", false); //se desactiva la animacion de correr
        }

        



    }
}
