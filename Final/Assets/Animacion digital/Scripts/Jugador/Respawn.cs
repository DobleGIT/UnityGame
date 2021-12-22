using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //esto lo usamos para resetear la escena
using UnityEngine.Audio; //lo utilizamos para el sonido


public class Respawn : MonoBehaviour
{
    private float posX = -6.76f;
    private float posY = -1.09f;
    public Animator animator;
    public AudioSource audioMuerte;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("posX",posX);
        PlayerPrefs.SetFloat("posY",posY);
        transform.position = (new Vector2(PlayerPrefs.GetFloat("posX"), PlayerPrefs.GetFloat("posY")));
    }

    public void MurioJugador()
    {
        audioMuerte.Play();
        animator.Play("hurt");
        StartCoroutine(retardoMuerte()); //iniciamos la corrutina 
        retardoMuerte();
        
    }
    IEnumerator retardoMuerte()
    {
        yield return new WaitForSeconds(0.3f); //hacemos que la muerte tarde para poder ver la animacion del daño
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //con esto reseteamos la escena al morir

    }

}
