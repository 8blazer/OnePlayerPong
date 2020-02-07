using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    bool toRight = true;
    int i = 0;
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight)
        {
            i++;
            transform.Rotate(0, 0, 1);
            if (i > 90)
            {
                i = 0;
                toRight = false;
            }

        }
        else
        {
            i++;
            transform.Rotate(0, 0, -1);
            if (i > 90)
            {
                i = 0;
                toRight = true;
            }
        }

    }
}
