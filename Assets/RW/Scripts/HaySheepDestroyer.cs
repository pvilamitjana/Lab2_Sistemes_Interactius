﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaySheepDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        Destroy(other.gameObject);
    }
}
