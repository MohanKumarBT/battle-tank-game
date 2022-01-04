using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float time;

    private void LateUpdate()
    {
        transform.position = Vector3.Slerp(transform.position, target.transform.position, time);
    }
}