using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToFirstPantalla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene("sceneinicio");
    }
    public void RegresarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}