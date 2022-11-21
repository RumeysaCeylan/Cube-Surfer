using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   
    public AudioSource victorySound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        { 
            
            Debug.Log("Victory");

            PlayerBehaviour.Instance.VictoryAnimation();

            PlayerBehaviour.Instance.StopPlayer();

            victorySound.Play();
            LevelText.level += 1; ;
           
            otherLevel();


        }

    }

    private void otherLevel()
    {
        System.Threading.Thread.Sleep(100);

        SceneManager.LoadScene(2);
    }
}
