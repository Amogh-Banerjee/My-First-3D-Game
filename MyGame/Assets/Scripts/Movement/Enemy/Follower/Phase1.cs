﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase1 : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void FixedUpdate () {
         Vector3 toTarget = player.transform.position - transform.position;
         float speed = 1.5f;
         
         transform.Translate(toTarget * speed * Time.deltaTime);
     }
}
