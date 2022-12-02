using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    // Start is called before the first frame update
    public void StartGame(){

        //string s = playerNameInput.text;
        //persistentData.Instance.SetName(s);
        SceneManager.LoadScene("Scene1");
        Debug.Log("Start");
        
        
    }

    public void Instructions() {
        SceneManager.LoadScene("Instructions");
    }
    public void back() {
        SceneManager.LoadScene("Menu");
    }
    public void NameEntry() {
        SceneManager.LoadScene("NameEntry");
    }
    public void Settings() {
        SceneManager.LoadScene("Settings");
    }
    public void gotoHighScore() {
        SceneManager.LoadScene("HighScore");
    }

    public void QuitGame(){
      
        Debug.Log("Quit");
        Application.Quit();
    }
}
