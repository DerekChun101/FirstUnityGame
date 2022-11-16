using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinmovement : MonoBehaviour
{
    
    [SerializeField] float speed = 10f;
    Rigidbody2D rigid;
    GameObject pin;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>(); 
        }

    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(3, 0);
    }

    void FixedUpdate()
    {
        rigid.AddForce(movement * speed);
    }

    

}
