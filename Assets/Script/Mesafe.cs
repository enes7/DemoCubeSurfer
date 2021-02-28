using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mesafe : MonoBehaviour
{
    public static Mesafe instance;
    public float mesafee;
    public Transform target;
    public Text mesafefark;

    void Start()
    {
        //aradakifark = transform.position - karakter.transform.position;


    }


    void Update()
    {
        mesafee = Vector3.Distance(transform.position, target.position);
        mesafefark.text = "" + mesafee + "m";
        

    }

    public void Awake()
    {
        if (instance ==null)
        {
            instance=this;
        }
    }
}
