using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İz : MonoBehaviour
{
    public GameObject karakter;
    Vector3 aradakifark;
     
    void Start()
    {
        aradakifark = transform.position - karakter.transform.position;

        
    }

    
    void Update()
    {
        transform.position = KarakterHareket.instance.prevdash.transform.position + aradakifark;

       

    }
    

    
}
