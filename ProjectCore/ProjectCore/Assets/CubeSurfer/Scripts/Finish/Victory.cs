using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public void NextLevel()
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        if(scene.buildIndex + 1 == 4)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(scene.buildIndex + 1);
        }
       
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
