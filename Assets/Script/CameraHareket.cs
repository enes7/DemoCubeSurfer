using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHareket : MonoBehaviour
{
    public Transform hedef;
    public Vector3 offset;
    public Animator anim;
    public float lerpDeger;
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 despos = hedef.position+offset;

        transform.position = Vector3.Lerp(transform.position, despos, lerpDeger);
    }
    void Update()
    {
        if (KarakterHareket.instance.cubsayisi > 2)
        {
            anim.SetBool("kamera", true);
        }
    }
}
