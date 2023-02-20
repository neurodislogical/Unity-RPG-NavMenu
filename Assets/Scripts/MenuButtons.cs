using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    //Join Button
    public void PlayGame()
    {
        SceneManager.LoadScene("Character Creation");
    }

    //Abandon Button
    public void QuitGame()
    {
        Debug.Log("ABANDON!");
        Application.Quit();    
    }

    //Back Button
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    //Next Button
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
    }

}
