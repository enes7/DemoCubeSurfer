using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Basla : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerDown(PointerEventData data)
    {

        KarakterHareket.instance.hareket = true;
        this.gameObject.SetActive(false);
        KarakterHareket.instance.anlik.gameObject.SetActive(true);
        KarakterHareket.instance.skor.gameObject.SetActive(true);
    }

    public void OnPointerUp(PointerEventData data)
    {


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
