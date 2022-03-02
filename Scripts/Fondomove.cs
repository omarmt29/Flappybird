using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondomove : MonoBehaviour
{
    //Variable del componente renderer de mi object
    Renderer rend;
    public float Velocidad = 0.4f;
    
    void Start()
    {
        //Igualando la variable del rend con el componente rendere que quiero
        rend = GetComponent<Renderer>();
    }

    
    void Update()
    {
        //Movimiento del fondo
        Vector2 Movimiento = new Vector2(Mathf.Repeat(Time.time * Velocidad, 1), 0.0f);
        //Math.Repeat(Time.time * FondoMovimiento, 1) se repite la animacion, se multiplica el tiempo por la variable y se pone 1
        rend.sharedMaterial.SetTextureOffset("_MainTex", Movimiento);
    }
}
