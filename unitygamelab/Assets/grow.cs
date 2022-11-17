using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
    float scale;
    [SerializeField] AudioSource audio;
    Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        scale = Random.Range(0.01f, 0.02f);
        InvokeRepeating("Grow", 1f, 0.05f);
        scaleChange = new Vector3(scale, scale, scale);

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void Grow()
    {
        if (gameObject.transform.localScale.x < 2.0 && gameObject.transform.localScale.y < 2.0)
            gameObject.transform.localScale += scaleChange; //Scale object up 
        else if (gameObject.transform.localScale.x > 1.9 && gameObject.transform.localScale.y > 1.9)// Destroys object if too big
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            CancelInvoke();
        }

    }
    
        
     



}
