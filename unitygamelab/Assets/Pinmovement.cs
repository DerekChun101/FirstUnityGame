using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinmovement : MonoBehaviour
{
    Vector2 movement;
    [SerializeField] float speed = 10f;
    Rigidbody2D rigid;
    public Movement cs;

    // Start is called before the first frame update
    void Start()
    {
       if (rigid == null)
           rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cs.isFacingRight == true)
        {
            movement = new Vector2(3, 0);
        }
        if (cs.isFacingRight == false)
            movement = new Vector2(0, 100);

    }

    void FixedUpdate()
    {
       
        rigid.AddForce(movement * speed);
    }

}
