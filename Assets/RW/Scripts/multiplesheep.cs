using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplesheep : MonoBehaviour
{

    public float inputKeyValue;
    public float MoveAmount = 1;

    public GameObject sheep;
    public float thresholdShoot = 1.5f;
    float measureTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        create();

    }

        /////// CREATING SHEEP  //////

    void create()
    {

        inputKeyValue = Random.Range(-10.0f, 10.0f); 
        //Debug.Log("value: " + inputKeyValue);
        
        Vector3 newPos = transform.position + Vector3.right * MoveAmount * inputKeyValue;
        if (newPos.x > -25 && newPos.x < 25){

            if ( (Time.time - measureTime)> thresholdShoot) 
        {
            // fem servir transform pk hay sigui un fill the machine 
            Instantiate(sheep, newPos, transform.rotation);

            measureTime = Time.time;
            
        }
            

        }

        

    }


}
