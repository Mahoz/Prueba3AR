using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Comenzarpartida : MonoBehaviour
{
    private Button boton;
    
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(ComenzarPartida);
    }

    void ComenzarPartida()
    {
        SceneManager.LoadScene("Juego");
    }
    
}
