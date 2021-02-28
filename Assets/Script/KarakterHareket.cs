using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class KarakterHareket : MonoBehaviour
{
    public static KarakterHareket instance;
    private Rigidbody rb;
    public bool hareket=false,sag,sol,bitiscizgi=false,hareket1;
    public GameObject dashesParent,prevdash,efekt;
    public float hiz;
    public int cubsayisi,bonusayisi;
    public GameObject anacub,sonucpanel,tap,anlik,skor;
    public Text skortxt,anlikskortxt,mesafesonuctxt;
    public Transform karakter;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anacub = this.gameObject;
        hareket=false;
        
    }


    


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Update()
    {
        //Instantiate(cub, new Vector3(anacub.transform.position.x, anacub.transform.position.y - anacub.transform.localScale.y / 1.8f, anacub.transform.position.z), transform.rotation);

        /*transform.Translate(0, 0, 1f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow)|| MobileInput.Instance.kaydirsol)
        {
            rb.velocity = Vector3.left * hiz * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || MobileInput.Instance.kaydirsag)
        {
            rb.velocity = Vector3.right * hiz * Time.deltaTime;
        }*/

        if (hareket == true)
        {
            Swerwe();
        }
        OyunDurum();

        anlikskortxt.text = "" + bonusayisi;

        if (bitiscizgi == true)
        {
            hareket = false;
            hareket1 = true;
            //sonucpanel.gameObject.SetActive(true);
            efekt.gameObject.SetActive(true);
            
            if (cubsayisi == 2)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 2;
            }
            if (cubsayisi == 3)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 3;
            }
            if (cubsayisi == 4)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 4;
            }
            if (cubsayisi == 5)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 5;
            }
            if (cubsayisi == 6)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 6;
            }
            if (cubsayisi == 7)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 7;
            }
            if (cubsayisi == 8)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 8;
            }
            if (cubsayisi == 9)
            {
                //karakter.localPosition = new Vector3(karakter.position.x, karakter.position.y, karakter.position.z + 1);
                //transform.position = Vector3.Lerp(transform.position, ilerle, 1 * Time.deltaTime);
                hareket = false;
                cubsayisi = bonusayisi * 9;
            }
        }
        

    }
    
    public void Swerwe()
    {
        
        Vector3 saggit = new Vector3(0.961f, transform.position.y, transform.position.z);
        Vector3 solgit = new Vector3(-0.100f, transform.position.y, transform.position.z);
        transform.Translate(0, 0, 1 * Time.deltaTime);

        

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, solgit, 20 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, saggit, 20 * Time.deltaTime);
        }
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);
            if (parmak.deltaPosition.x > 50f)
            {
                sag = true;
                sol = false;
            }

            if (parmak.deltaPosition.x > 50f)
            {
                sag = false;
                sol = true;
            }

            if (sag == true)
            {
                transform.position = Vector3.Lerp(transform.position, saggit, 5 * Time.deltaTime);
            }
            if (sol == true)
            {
                transform.position = Vector3.Lerp(transform.position, solgit, 5 * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (KarakterHareket.instance.cubsayisi > 0)
        {

            if (other.gameObject.tag == "Maviengel")
            {

                //KarakterHareket.instance.cubsayisi--;
                Destroy(other.gameObject);
                //this.gameObject.SetActive(false);
                hareket = false;
                hareket1 = true;
                if (KarakterHareket.instance.cubsayisi == 0)
                {
                    KarakterHareket.instance.hareket = false;
                }



            }
            

        }


        if (other.gameObject.tag == "bitis")
        {
            bitiscizgi = true;
            hareket1 = true;
        }

    }



    public void DashesTake(GameObject dash)
    {
        if (hareket == true)
        {
            cubsayisi++;
            bonusayisi++;
            dash.transform.SetParent(dashesParent.transform);
            Vector3 pos = prevdash.transform.localPosition;
            pos.y -= 0.2f;
            dash.transform.localPosition = pos;


            Vector3 karakterpos = transform.localPosition;
            karakterpos.y += 0.06f;
            transform.localPosition = karakterpos;
            prevdash = dash;

            prevdash.GetComponent<BoxCollider>().isTrigger = false;
        }
        

        
        
    }

    public void OyunDurum()
    {
        if (hareket==false)
        {
            
            skortxt.text = "" + cubsayisi*bonusayisi;
            mesafesonuctxt.text = "" + Mesafe.instance.mesafee+"m";
        }
        if (hareket1 == true)
        {
            sonucpanel.gameObject.SetActive(true);
        }
    }

    
    /*public void Engeller()
    {
        GameObject obj = ObjectPool.current.GetPoolObject();
        if (obj == null) return;

        obj.transform.position = karakter.transform.position.;
        obj.transform.rotation = karakter.rotation;
        obj.SetActive(true);
    }*/



    /*private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Engel"))
        {
            CubAzalt(other.gameObject);
        }
    }

    private void CubAzalt(GameObject gameObject)
    {
        int engelsayisi=gameObject.transform.GetChild(0).
        cubsayisi--;
    }*/
}
