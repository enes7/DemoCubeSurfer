using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public static CubeScript instance;
    
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Dashes")
        {
            other.gameObject.tag = "Normal";
            KarakterHareket.instance.DashesTake(other.gameObject);
            other.gameObject.AddComponent<Rigidbody>();
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
            other.gameObject.AddComponent<CubeScript>();
            Destroy(this);

        }

        
    }

    



    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
