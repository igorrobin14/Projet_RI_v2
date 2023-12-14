using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeplacementAsterOr : MonoBehaviour
{
    public Transform _trigger;
    private Transform _AsterOr;
    private int _speed;
    private Vector3 _distance;
    // Start is called before the first frame update
    void Start()
    {
        _speed = 5;
        _AsterOr=GetComponent<Transform>();

        
    }

    // Update is called once per frame
    void Update()

    {
        
        
       _AsterOr.Translate(-Vector3.back*Time.deltaTime*_speed);

        
    }
}
