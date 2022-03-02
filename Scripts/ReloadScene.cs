using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{

    string scene = "MenuPlay";
    public bool a = false;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(a == true)
        {
         a = false;
         Recargar();
         

        }
    }

    public void Recargar()
    {
      SceneManager.LoadScene(scene);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
      a = true;
      Destroy(other.gameObject); 
    }


    
}
