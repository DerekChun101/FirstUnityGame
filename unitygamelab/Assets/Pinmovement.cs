using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinmovement : MonoBehaviour
{
    GameObject playerObj = null;
    [SerializeField] GameObject pinPrefab;
    Vector2 movement;
    [SerializeField] float speed = 1f;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector2(movement * speed, 0);

    }

    

}
