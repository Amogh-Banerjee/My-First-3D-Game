using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish2 : MonoBehaviour
{
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -60f)
            
        {
            Text.GetComponent<Renderer>().enabled = true;
         }
       else
        {
            Text.GetComponent<Renderer>().enabled = false;
        }
    }
}
