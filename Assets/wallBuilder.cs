using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBuilder : MonoBehaviour
{
    //Ezzel fogjuk megkeresni magát a bricket:
    public GameObject brickPrototype;

    //Pivot pont beállítása:
    float x0 = -8.5f;
    float y0 = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                GameObject brickClone = Instantiate(brickPrototype);
                brickClone.transform.position = new Vector3(((x0 + 2*j)+i%2), y0 + i, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
