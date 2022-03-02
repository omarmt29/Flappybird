using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TuboHandler : MonoBehaviour
{
    public List<GameObject> tubos;
    public float Offset_x;
    float max = 2.57f;
    float min = -3.06f;
    public int Score = 0;
    public TextMeshProUGUI textmesh;
    public void push_tubo()
    {

      tubos[0].transform.position = new Vector2(tubos[tubos.Count-1].transform.position.x + Offset_x,Random.Range(max,min));
      GameObject UnaCajita = tubos[0];
      tubos.RemoveAt(0);
      tubos.Insert(tubos.Count, UnaCajita);
      suma();

    }
    public void suma()
    {
      Score = Score + 1;
      textmesh.text = Score.ToString();
      Debug.Log(Score);
    }
    public void ultimopuntaje()
    {
      textmesh.text = Score.ToString();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
      Destroy(other.gameObject); 
    }

  


}
