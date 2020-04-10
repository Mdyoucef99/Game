using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{



    public void load() {
        SceneManager.LoadScene("GAME");
    }


    public void Exit() {

        Application.Quit();

    }


    public void ShowOptions() {

       
    
    }
  
}
