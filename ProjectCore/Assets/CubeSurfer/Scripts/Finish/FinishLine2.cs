using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine2 : MonoBehaviour
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
            
            SceneManager.LoadScene(1);


        }

    }

   
}
