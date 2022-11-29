using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    public void StartGame(){
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        SceneManager.LoadScene("Scene1");
        Debug.Log("Start");
        
    }

    public void QuitGame(){
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        Debug.Log("Quit");
        Application.Quit();
    }
}
