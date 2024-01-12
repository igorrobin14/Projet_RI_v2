using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    
    private float vitesse = 10;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * vitesse * Time.deltaTime;
    }
}