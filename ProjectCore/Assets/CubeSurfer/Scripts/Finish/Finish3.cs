using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish3 : MonoBehaviour
{
    public AudioSource victorySound;
    [SerializeField] private float delayBeforeLoading = 10f;

    private float timeElapsed;
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {


            Debug.Log("Victory");

            PlayerBehaviour.Instance.VictoryAnimation();

            PlayerBehaviour.Instance.StopPlayer();

            victorySound.Play();
            LevelText.level += 1; 






        }

    }
}