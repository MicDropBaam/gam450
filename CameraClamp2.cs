using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp2 : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow2;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow2.position.x, 12.0f, 34.0f),
            transform.position.y,//Mathf.Clamp(targetToFollow.position.y, -3f, 3f),
            transform.position.z);


    }
}
