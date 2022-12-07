using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    private Button boton;

    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(SaliR);
    }
    void SaliR()
    {
        Application.Quit();
    }
}
