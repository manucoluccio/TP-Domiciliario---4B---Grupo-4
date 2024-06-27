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
    bool botonPresionado = false;

    // Start is called before the first frame update
    void Start()
    {
        panelMal_Bien.SetActive(false);
        panelSeleccion.SetActive(false);
        DeactivarProductos();
        CreacionDePrecios();
       
        
        ActivarProductos(19f, 42f, 0);
        precioSuma = precio[ProductoRandom];
        txt_preciosSuma.text = "$" + precioSuma.ToString();
        ActivarProductos(12f, 42f, 0);
        precio1 = precio[ProductoRandom];
        txt1.text = "$" + precio1.ToString();
        ActivarProductos(22f, 42f, 0);
        precio2 = precio[ProductoRandom];
        txt2.text = "$" + precio2.ToString();
        ActivarProductos(61f, 34f, 0);
        precio3 = precio[ProductoRandom];
        txt3.text = "$" + precio3.ToString();
        precioRandom = Random.Range(1, 4);
        
        
        if (precioRandom == 1)
        {
            SumaDePrecio = precioSuma + precio1;
        }
        else if (precioRandom == 2)
        {
            SumaDePrecio = precioSuma + precio2;
        }
        else if (precioRandom == 3)
        {
            SumaDePrecio = precioSuma + precio3;
        }
        txt_Suma.text = "$" + SumaDePrecio.ToString();
    }

    // Update is called once per frame
    void Update()
    {

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
        x = Mathf.Clamp(x, 0f, Screen.width - 100f);
        y = Mathf.Clamp(y, 0f, Screen.height - 100f);
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
    public void Producto1()
    {
        ProductosSeleccionados = 1;
        txt1.fontStyle = FontStyle.Bold;
        txt2.fontStyle = FontStyle.Normal;
        txt3.fontStyle = FontStyle.Normal;
    }
    public void Producto2()
    {
        ProductosSeleccionados = 2;
        txt2.fontStyle = FontStyle.Bold;
        txt1.fontStyle = FontStyle.Normal;
        txt3.fontStyle = FontStyle.Normal;
    }
    public void Producto3()
    {
        ProductosSeleccionados = 3;
        txt3.fontStyle = FontStyle.Bold;
        txt2.fontStyle = FontStyle.Normal;
        txt1.fontStyle = FontStyle.Normal;
    }

    public void RespuestaDeBotonoes()
    {


        botonPresionado = true; 

        if (ProductosSeleccionados == 1)
        {
            if (precio1 + precioSuma == SumaDePrecio)
            {
                panelMal_Bien.SetActive(true);
                txt_notificacion.text = "Ganaste!!!";
                txt_btnVolverAJugar.text = "Volver A Jugar";
            }
            else
            {
                panelMal_Bien.SetActive(true);
                txt_notificacion.text = "Perdiste";
                txt_btnVolverAJugar.text = "Volver a intentar";
            }
        }
        else if (ProductosSeleccionados == 2)
        {
            if (precio2 + precioSuma == SumaDePrecio)
            {
                panelMal_Bien.SetActive(true);
                txt_notificacion.text = "Ganaste!!!";
                txt_btnVolverAJugar.text = "Reiniciar Desafío";
            }
            else
            {
                panelMal_Bien.SetActive(true);
                txt_notificacion.text = "Perdiste";
                txt_btnVolverAJugar.text = "Volver a intentar";
            }
        }
        else if (ProductosSeleccionados == 3)
        {
            if (precio3 + precioSuma == SumaDePrecio)
            {
                panelMal_Bien.SetActive(true);
                txt_notificacion.text = "Ganaste!!!";
                txt_btnVolverAJugar.text = "Reiniciar Desafío";
            }
            else
            {
                panelMal_Bien.SetActive(true);
                txt_notificacion.text = "Perdiste";
                txt_btnVolverAJugar.text = "Volver a intentar";
            }
        }
        else
        {
            StartCoroutine(MostrarPanelTemporalmente());
        }
    }

    IEnumerator MostrarPanelTemporalmente()
    {
        panelSeleccion.SetActive(true);
        yield return new WaitForSeconds(3f);
        panelSeleccion.SetActive(false);
    }
}