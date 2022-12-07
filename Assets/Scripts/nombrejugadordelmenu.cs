using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nombrejugadordelmenu : MonoBehaviour
{
    public static string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringInput(string s)
    {
        nombrejugadorenlapantalla.jugadorenpantalla = s;
        Debug.Log(s);

    }
}
