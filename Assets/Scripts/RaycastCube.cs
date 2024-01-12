using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCube : MonoBehaviour
{
    Vector3 _directionRay;
    Vector3 _positionDepart;
    bool _rayOn = true;
    Transform _tfCube;
    Renderer _rdCube;



    // Start is called before the first frame update
    void Start()
    {
        _tfCube = GetComponent<Transform>();
        _rdCube = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        _positionDepart = _tfCube.position;
        _directionRay = -_tfCube.up;
        Debug.DrawRay(_positionDepart, _directionRay,Color.red);
        
        if(Physics.Raycast(_positionDepart,_directionRay,out hit, 10) && _rayOn )
        {
            Debug.Log(hit.collider.GetComponent<Transform>().name);
            hit.collider.GetComponent<Transform>().Rotate(0, 100*Time.deltaTime, 0);
            SetColor(Color.red);
        }
        else
        {
            if (_rdCube.material.color == Color.red)
            {
                SetColor(Color.white);
            }
        }
        if(Input.GetMouseButtonDown(0))
        {
            _rayOn = !_rayOn;
            
        }
       
    }

    private void SetColor(Color couleur)
    {
        _rdCube.material.color = couleur;
    }
}
