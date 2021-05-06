using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMachineControl : MonoBehaviour
{

    public float inputKeyValue;
    public float MoveAmount = 1;

    public GameObject hayShootObject;
    public float thresholdShoot = 0.5f;
    float measureTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        measureTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Shoot();
    }

    /////// MOVING //////

    void Move ()
    {
        inputKeyValue = Input.GetAxis("Horizontal"); 
        //Debug.Log("value: " + inputKeyValue);
        
        Vector3 newPos = transform.position + Vector3.right * MoveAmount * inputKeyValue;
        if (newPos.x > -21 && newPos.x < 21){

            transform.Translate(Vector3.right*MoveAmount* inputKeyValue);

        }

    }

    /////// SHOOTING //////

    void Shoot()
    {

        if (Input.GetKey(KeyCode.Space) && (Time.time - measureTime)> thresholdShoot) 
        {
            // fem servir transform pk hay sigui un fill the machine 
            Instantiate(hayShootObject, transform.position, Quaternion.identity, transform);

            measureTime = Time.time;
        }

    }

}
