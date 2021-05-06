using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class HayDestroyer : MonoBehaviour
{

   // public TextMeshProGUI countText;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        //SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        Destroy(other.gameObject);
        count = count + 1;
        //SetCountText();
    }

   /* void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
      
    }*/
}
