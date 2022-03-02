using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    
    float y_inicial;

    void Start()
    {
        y_inicial = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //el movimiento de la camara es igual a la posicion X igual que es el del player + la inicial de Y para que se quede sin subir ni bajar e
        transform.position = new Vector3( transform.position.x, y_inicial, -1.81f);


    }
}
