using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waxControl : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        // wax destroying hairs
        if (other.gameObject.CompareTag("Hair"))
        {            
            Destroy(other.gameObject);
        }

        // cleaner deleting all waxes
        if (other.gameObject.CompareTag("Cleaner"))
        {
            Destroy(this.gameObject);
        }
    }
}
