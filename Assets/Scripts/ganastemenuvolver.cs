using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ganastemenuvolver : MonoBehaviour
{
    // Start is called before the first frame update
    private Button boton;

    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(volverr);
    }

    // Update is called once per frame
    void volverr()
    {
        SceneManager.LoadScene("Menu");
    }
}
