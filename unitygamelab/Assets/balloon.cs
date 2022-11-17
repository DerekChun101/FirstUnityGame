using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.CompareTag("balloon")))
        {
            Destroy(other.gameObject);
        }
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        score();
    }
    void score()
    {
        if (gameObject.transform.localScale.x > 1.0 && gameObject.transform.localScale.y > 1.0)
            controller.GetComponent<Score>().UpdateScore(2);
        if (gameObject.transform.localScale.x > 2.0 && gameObject.transform.localScale.y > 2.0)
            controller.GetComponent<Score>().UpdateScore(3);
    }
}
