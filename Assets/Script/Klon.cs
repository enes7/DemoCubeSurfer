using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klon : MonoBehaviour
{
    public float sagkisim = 0.300f;
    public float solkisim = -0.167f;
    public float ortakisim = 0.140f;
    public GameObject cub,cub2;
    public Transform karakter;
    void Start()
    {
        if(KarakterHareket.instance.hareket == true)
        {
            InvokeRepeating("Klonla", 0, 1.0f);
            InvokeRepeating("Klonla1", 0, 3.0f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void Klonla()
    {
        int sayi = Random.Range(0, 100);

        if (sayi > 0 && sayi < 100)
        {
            Olustur(cub, 0.3f);
        }
    }
    public void Klonla1()
    {
        int sayi = Random.Range(0, 100);

        if (sayi > 0 && sayi < 100)
        {
            Olustur1(cub2, 0.3f);
        }
    }

    public void Olustur(GameObject nesne, float ust)

    {
        
        GameObject yeniklon = Instantiate(nesne);
        int sayi = Random.Range(0, 100);

        if (sayi < 70)
        {
            yeniklon.transform.position = new Vector3(sagkisim, karakter.transform.position.y+cub.transform.localScale.y, karakter.position.z + 3);


        }
        if (sayi > 70)
        {
            yeniklon.transform.position = new Vector3(solkisim, karakter.transform.position.y + cub.transform.localScale.y, karakter.position.z + 4);
        }
        if (sayi < 30)
        {
            yeniklon.transform.position = new Vector3(ortakisim, karakter.transform.position.y + cub.transform.localScale.y, karakter.position.z + 5);
        }
    }
    public void Olustur1(GameObject nesne, float ust)

    {

        GameObject yeniklon = Instantiate(nesne);
        int sayi = Random.Range(0, 100);

        if (sayi < 70)
        {
            yeniklon.transform.position = new Vector3(sagkisim, karakter.transform.position.y, karakter.position.z + 6);


        }
        if (sayi > 70)
        {
            yeniklon.transform.position = new Vector3(solkisim, karakter.transform.position.y, karakter.position.z + 6);
        }
        if (sayi < 30)
        {
            yeniklon.transform.position = new Vector3(ortakisim, karakter.transform.position.y, karakter.position.z + 6);
        }
    }



}
