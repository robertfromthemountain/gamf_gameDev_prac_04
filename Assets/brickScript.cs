using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class brickScript : MonoBehaviour
{
    int life = 3;
    public Sprite spriteRepedt1;
    public Sprite spriteRepedt2;

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ball")
        {
            life--;
            if (life == 2) { sr.sprite = spriteRepedt1; }
            if (life == 1) { sr.sprite = spriteRepedt2; }
            if (life == 0) { Destroy(gameObject); }
        }

    }
}
