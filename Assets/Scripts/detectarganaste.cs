using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectarganaste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jammo_LowPoly")
        {
            SceneManager.LoadScene("Ganaste");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
