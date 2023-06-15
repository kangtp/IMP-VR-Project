using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void OrderButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    
    //call this method when "quit" is pressed
    public void QuitGame()
    {
        //run this code only in editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //stop play mode
#endif
        Application.Quit(); //whe running as build game
}
}
