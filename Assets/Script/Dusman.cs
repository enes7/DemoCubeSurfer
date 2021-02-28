using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public static Dusman instance;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (KarakterHareket.instance.cubsayisi > 0)
        {
            
            if (other.gameObject.tag == "Maviengel")
            {
                
                //KarakterHareket.instance.cubsayisi--;
                Destroy(this.gameObject);
                //this.gameObject.SetActive(false);
                KarakterHareket.instance.hareket = false;
                if (KarakterHareket.instance.cubsayisi == 0)
                {
                    KarakterHareket.instance.hareket = false;
                }



            }
            
        }
        
    }*/
}
