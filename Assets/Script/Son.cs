using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "birplane")
        {
            KarakterHareket.instance.cubsayisi--;
        }
    }
}
