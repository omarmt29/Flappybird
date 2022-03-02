using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    //Fuerza del salto
    public float FuerzaDeSalto = 0f;
    public float VelocidadPlayer = 3.5f;

    void Start()
    {
       
    }

    void Update()
    {

        //si doy click aplica fuerza en el eje Y para arriba y activa la animacion
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f,FuerzaDeSalto);
            GetComponent<Animator>().SetBool("Fly", true);
        }
        else //si no la animacion se desactiva
        {
            GetComponent<Animator>().SetBool("Fly", false);
        }

        // selecciona el componente digid del objeto .velocidad igual a la cantidad de velocidad aplicada en el eje dejando igual la Y
        GetComponent<Rigidbody2D>().velocity = new Vector2(VelocidadPlayer ,GetComponent<Rigidbody2D>().velocity.y);
    }

    
 
    




    

    
}
