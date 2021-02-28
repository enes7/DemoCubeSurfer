using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rout : MonoBehaviour
{
    [SerializeField]
    private Transform[] controlpoint;

    private Vector2 gizmosposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDrawingGizmos()
    {
        for(float t = 0; t <= 1; t += 0.05f)
        {
            gizmosposition = Mathf.Pow(1 - t, 3) * controlpoint[0].position +
                3 * Mathf.Pow(1 - t, 2) * controlpoint[1].position +
                3 * (1 - t) * Mathf.Pow(t, 2) * controlpoint[2].position;
            Gizmos.DrawSphere(gizmosposition, 0.25f);
                
        }

        Gizmos.DrawLine(new Vector2(controlpoint[0].position.x, controlpoint[0].position.y),
            new Vector2(controlpoint[1].position.x, controlpoint[1].position.y));

        Gizmos.DrawLine(new Vector2(controlpoint[2].position.x, controlpoint[2].position.y),
            new Vector2(controlpoint[2].position.x, controlpoint[2].position.y));



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
