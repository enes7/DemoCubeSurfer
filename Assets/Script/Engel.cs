using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    public Transform karakter;
    public GameObject obj,obj1;
    public float fireTime = 2f;

    public void Awake()
    {

    }



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", fireTime, fireTime);
    }

    public void Fire()
    {
        GameObject obj= GameObject.Find("objectPooler").GetComponent<ObjectPool>().GetHavuzObje();
        obj.transform.position = karakter.transform.position-karakter.transform.position/1.5f;
        obj.SetActive(true);
    }

    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
