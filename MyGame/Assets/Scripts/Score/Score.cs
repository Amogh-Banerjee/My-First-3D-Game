using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text label;
    private float distance;
    // Update is called once per frame
    void Update()
    {
        if (player.position.x <= 0)
        {
            distance = -player.position.x;
            label.text = distance.ToString("0");
        }
        
    }
    
     
    // public GameObject player;
 
      //void score(){
          
  
          //GetComponent(label).text = "blah";
          //label.Text = distance.ToString ();
      //}
}
