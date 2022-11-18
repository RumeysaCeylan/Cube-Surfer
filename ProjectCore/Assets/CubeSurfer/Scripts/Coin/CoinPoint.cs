using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPoint : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Cube")
        {
            CoinText.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}
