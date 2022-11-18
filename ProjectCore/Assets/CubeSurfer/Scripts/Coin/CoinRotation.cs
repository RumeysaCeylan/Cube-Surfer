using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAngle;
    //[SerializeField] private float rotationSpeed;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1*rotationAngle*Time.deltaTime);
    }
}
