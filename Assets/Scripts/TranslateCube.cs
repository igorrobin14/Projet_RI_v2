using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateCube : MonoBehaviour
{
    private Transform _tfCube;
    // Start is called before the first frame update
    void Start()
    {
        _tfCube = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _tfCube.Translate(1*Time.deltaTime,0,0);
    }
}
