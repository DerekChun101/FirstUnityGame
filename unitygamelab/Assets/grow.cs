using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Grow", 1f, 0.03f);
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void Grow()
    {
        if (gameObject.transform.localScale.x < 2.0 && gameObject.transform.localScale.y < 2.0)
            gameObject.transform.localScale += scaleChange;
        else if (gameObject.transform.localScale.x > 1.9 && gameObject.transform.localScale.y > 1.9)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            CancelInvoke();
        }

    }
    
        
     



}
