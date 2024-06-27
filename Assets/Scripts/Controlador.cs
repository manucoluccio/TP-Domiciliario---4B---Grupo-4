using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public GameObject[] Productos;
    Dictionary<GameObject, int> precio = new Dictionary<GameObject, int>();
    GameObject ProductoRandom;
    public Text txt_preciosSuma;
    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt_btnVolverAJugar;
    public Text txt_notificacion;
    public GameObject panelMal_Bien;
    public GameObject panelSeleccion;
    int rprecioRandom;
    int SumaDePrecio;
    int ProductosSeleccionados;
    int precioSuma;
    int precio1;
    int precio2;
    int precio3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeactivateAll()
    {
        for (int i = 0; i < Productos.Length; i++)
        {
            Productos[i].SetActive(false);
        }

    }
}
