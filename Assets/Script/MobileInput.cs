using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : MonoBehaviour
{
    public static MobileInput Instance { set; get; }

    public bool tap, kaydirsol, kaydirsag;
    public Vector2 kaydirDelta, ilkdok;
    private const float deadZone = 100;

    private void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        tap = kaydirsag = kaydirsol = false;

        //for pc

        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            ilkdok = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ilkdok = kaydirDelta = Vector2.zero;
        }

        //for mobile

        if (Input.touches.Length != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                ilkdok = Input.mousePosition;
            }
            else if(Input.touches[0].phase==TouchPhase.Ended|| Input.touches[0].phase == TouchPhase.Canceled)
            {
                ilkdok = kaydirDelta = Vector2.zero;
            }
        }

        kaydirDelta = Vector2.zero;
        if (ilkdok != Vector2.zero)
        {
            if (Input.touches.Length != 0)
            {
                kaydirDelta = Input.touches[0].position - ilkdok;

            }
            else if (Input.GetMouseButton(0))
            {
                kaydirDelta = (Vector2)Input.mousePosition - ilkdok;
            }
        }

        if (kaydirDelta.magnitude > deadZone)
        {
            float x = kaydirDelta.x;
            float y = kaydirDelta.y;

            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                {
                    kaydirsol = true;
                }
                else
                {
                    kaydirsag = true;
                }
            }

            ilkdok = kaydirDelta = Vector2.zero;
        }
    }
}
