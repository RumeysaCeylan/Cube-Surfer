using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;

    private Vector3 newPosition;
    private Vector3 offset;

   
    void Start()
    {
        SetOffsetValue();
    }


    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }



    private void SetOffsetValue()
    {
        offset = transform.position - heroTransform.position;

    }



    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.z) + offset, 1 * Time.deltaTime);
        transform.position = newPosition;
    }
}
