using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAsteroideSaturne : MonoBehaviour
{
    private GameObject _saturne;
    private float _rotationSpeed;

    void Start()
    {
        _saturne = GameObject.Find("Saturne");
        _rotationSpeed = 1 + Random.value + Random.value + Random.value + Random.value + Random.value; 
    }

    void Update()
    {
        Vector3 rotationAxis = Vector3.up;
        float totalRotation = _rotationSpeed * Time.deltaTime;
        transform.RotateAround(_saturne.transform.position, rotationAxis, totalRotation);
    }
}