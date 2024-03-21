using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    int life =3;
    float speed = 8.0f;
    float xMin = -10.4f, xMax = 10.4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Ha nyomvatartjuk valamelyik gombot, akkor arra mozdul a slider:
        if (Input.GetKey(KeyCode.A) && transform.position.x > xMin) { transform.Translate(speed * (Vector3.left * Time.deltaTime)); }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > xMin) { transform.Translate(speed * (Vector3.left * Time.deltaTime)); }
        if (Input.GetKey(KeyCode.D) && transform.position.x < xMax) { transform.Translate(speed * (Vector3.right * Time.deltaTime)); }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < xMax) { transform.Translate(speed * (Vector3.right * Time.deltaTime)); }
    }
}
