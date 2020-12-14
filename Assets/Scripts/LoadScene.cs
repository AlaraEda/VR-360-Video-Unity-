using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void GoToVideo1() {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("Video1");
    }

    public void GoToVideo2() {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("Video2");

        //Restart
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

}
