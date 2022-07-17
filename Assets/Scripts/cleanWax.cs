using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanWax : MonoBehaviour
{
    private bool hairs;

    
    private void Start()
    {
        Destroy(this.gameObject, 2.1f);
    }

 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hair"))
        {
            Debug.Log("Touch");
        }
    }
}
