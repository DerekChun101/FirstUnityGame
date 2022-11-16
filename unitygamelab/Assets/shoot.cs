using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shoot : MonoBehaviour
{
    GameObject playerObj = null;
    [SerializeField] bool fire = true;
    [SerializeField] GameObject pinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            
            spawn();
           

        }
        
    }
    void spawn()
    {
        float x = playerObj.transform.position.x;
        float y = playerObj.transform.position.y;
        

        Vector2 position = new Vector2(x, y);
        Instantiate(pinPrefab, position, Quaternion.identity);
        fire = true;

    }

}
