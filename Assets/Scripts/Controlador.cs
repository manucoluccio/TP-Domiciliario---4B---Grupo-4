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
    public Text txt_Suma;
    public Text txt_btnVolverAJugar;
    public Text txt_notificacion;
    public GameObject panelMal_Bien;
    public GameObject panelSeleccion;
    int precioRandom;
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
        panelSeleccion.SetActive(false);
        panelMal_Bien.SetActive(false);
        DeactivarProductos();
        CreacionDePrecios();
        ActivarProductos(-185f, -189f, 0);
        precioSuma = precio[ProductoRandom];
        txt_preciosSuma.text = "$" + precioSuma.ToString();
        ActivarProductos(-28f, -189f, 0);
        precio1 = precio[ProductoRandom];
        txt1.text = "$" + precio1.ToString();
        ActivarProductos(167f, -189f, 0);
        precio2 = precio[ProductoRandom];
        txt2.text = "$" + precio2.ToString();
        ActivarProductos(-110f, -75f, 0);
        precio3 = precio[ProductoRandom];
        txt3.text = "$" + precio3.ToString();
        precioRandom = Random.Range(1, 4);
        if (precioRandom == 1)
        {
            SumaDePrecio = precioSuma + precio1;
        }
        else if (precioRandom == 2)
        {
            SumaDePrecio = SumaDePrecio = precioSuma + precio2;
        }
        else if (precioRandom == 3)
        {
            SumaDePrecio = SumaDePrecio = precioSuma + precio3;
        }
        txt_Suma.text = "$" + SumaDePrecio.ToString();
    }
    public void DeactivarProductos()
    {
        for (int i = 0; i < Productos.Length; i++)
        {
            Productos[i].SetActive(false);
        }

    }
    void ActivarProductos(float x, float y, float z)
    {
        int randomIndex = Random.Range(0, Productos.Length);
        ProductoRandom = Productos[randomIndex];
        ProductoRandom.transform.position = new Vector3(x, y, z);
        ProductoRandom.SetActive(true);
    }
    void CreacionDePrecios()
    {
        for (int i = 0; i < Productos.Length; i++)
        {
            precio.Add(Productos[i], Random.Range(1, 19));
        }
    }
}
