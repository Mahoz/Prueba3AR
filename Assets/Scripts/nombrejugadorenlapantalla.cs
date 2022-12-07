using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nombrejugadorenlapantalla : MonoBehaviour
{
    public static string jugadorenpantalla;
    Text Jugador;

    void Start()
    {
        Jugador = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Jugador.text = "Jugador: " + jugadorenpantalla;
    }
}
