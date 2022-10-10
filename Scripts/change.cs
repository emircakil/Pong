using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Start is called before the first frame update


    public void changeScne(string str) {

        
        SceneManager.LoadScene(str);
    }

    public void quitGame() { 
    
        Application.Quit();
    }
}
