using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Controlador : MonoBehaviour
{
    // Productos y precios
    private List<Producto> products = new List<Producto>();
    private Producto currentProduct;
    private int currentPrice;

    // UI Elements
    public Text operationText;
    public Text priceText;
    public Button[] productButtons;
    public Button respondButton1;
    public Button respondButton2;
    public Button respondButton3;
    public Text notificationText;
    public Button playAgainButton;
    public Button exitButton;

    // Estado del juego
    private bool isProductoSelected = false;
    private Producto selectedProduct;

    // Start is called before the first frame update
    void Start()
    {
        // Inicializar productos y precios
        products.Add(new Producto("Producto1", 5));
        products.Add(new Producto("Producto2", 7));
        products.Add(new Producto("Producto3", 3));
        products.Add(new Producto("Producto4", 15));
        // ...
        // 20 productos en total

       
    


    }

    public class Producto
    {
        public string icon;
        public int price;

        public Producto(string icon, int price)
        {
            this.icon = icon;
            this.price = price;
        }


        void Update()
        {

        }
    }
}