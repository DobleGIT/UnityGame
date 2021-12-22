using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemGlobal : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textoFinal;

    // Update is called once per frame
    private void Update()
    {
        cherrysRecogidos();
        
    }

    public void cherrysRecogidos()
    {
        if(transform.childCount == 0)
        {
            if((SceneManager.GetActiveScene().buildIndex) == 1) //si es la escena final que muestre el texto 
            {
                textoFinal.gameObject.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //esta parte carga la escene y le suma 1 a build index que es el numero de esceneas

            }

        }
    }
}
