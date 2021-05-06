using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMove : MonoBehaviour
{

    public float speed ;

    public float runSpeed ;
    public float gotHayDestroyDelay;
    private bool hitByHay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      transform.Translate(Vector3.back * speed, Space.World);

    }

    private void HitByHay()
    {
      hitByHay = true; //1
      runSpeed = 0; //2
      Destroy(gameObject, gotHayDestroyDelay);
    }

    /*private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Hay") && !hitByHay)
      {
        Destroy(other.gameobject);
        HitByHay();
      }
    }*/
}
