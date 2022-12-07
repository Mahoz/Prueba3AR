using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class volveralmenu : MonoBehaviour
{
    // Start is called before the first frame update
    private Button boton;
    
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(volvermenu);
    }

    void volvermenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
