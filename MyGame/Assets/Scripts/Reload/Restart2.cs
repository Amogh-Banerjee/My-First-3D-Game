using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < 10f)
             transform.position = new Vector3(35f,17f,-9f);
    }
}
