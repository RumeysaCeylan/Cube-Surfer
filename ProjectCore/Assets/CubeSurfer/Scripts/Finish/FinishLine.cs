using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   
    public AudioSource victorySound;

    public AudioSource fireworkSound;



    public GameObject nextButton;
    public GameObject menuButton;

    public ParticleSystem fireworks;

  


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        { 
            
            Debug.Log("Victory");

            PlayerBehaviour.Instance.VictoryAnimation();

            PlayerBehaviour.Instance.StopPlayer();

            victorySound.Play();

            fireworkSound.Play();

            fireworks.Play();

            nextButton.SetActive(true);
            menuButton.SetActive(true);







        }

    }

   
}
