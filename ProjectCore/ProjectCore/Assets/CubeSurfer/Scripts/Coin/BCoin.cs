using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCoin : MonoBehaviour
{
    public AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            CoinText.coinAmount += 10;

            coinSound.Play();

            Destroy(gameObject);
        }

    }
}
