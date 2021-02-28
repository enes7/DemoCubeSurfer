using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    List<GameObject> havuzObje;
    public int havuzAmount = 10;
    public GameObject mavi_engel;

    public void Awake()
    {
        
    }

    

    
    void Start()
    {
        havuzObje = new List<GameObject>();
        int i;
        for (i = 0; i < havuzAmount; i++)
        {
            GameObject obj=(GameObject) Instantiate(mavi_engel);
            obj.SetActive(false);
            havuzObje.Add(obj);

            
        }


    }

    public GameObject GetHavuzObje()
    {
        int i;
        for (i = 0; i < havuzAmount; i++)
        {
            if (!havuzObje[i].activeInHierarchy)
            {
                return havuzObje[i];
            }
        }
        return null;
    }

    
    void Update()
    {
        
    }
}
