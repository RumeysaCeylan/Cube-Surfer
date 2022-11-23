using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTransform : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAngle;
    


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1 * rotationAngle * Time.deltaTime);
    }
}
