using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tubo : MonoBehaviour
{
  string scene = "mainscene";
  public bool a = false;
  public void Update()
  {
    if(a == true)
    {
      a = false;
     
      Recargar();
    }
  }
  public void OnCollisionEnter2D(Collision2D other)
  {
    a = true;
    Destroy(other.gameObject); 
  }
  public void OnBecameInvisible()
  {
    transform.parent.transform.parent.GetComponent<TuboHandler>().push_tubo();
  }
  public void Recargar()
  {
    SceneManager.LoadScene(scene);
  }


  
 

  
    
}
