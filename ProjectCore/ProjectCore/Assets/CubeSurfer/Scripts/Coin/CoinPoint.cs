using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPoint : MonoBehaviour
{

    public AudioSource coinSound;

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Cube")
        {
            
            CoinText.coinAmount += 1;

            coinSound.Play();
            
            Destroy(gameObject);
        }
       
    }
}
