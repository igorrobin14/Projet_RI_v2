using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturneRotation : MonoBehaviour
{
    //Start is called before the first frame update
    private float _vitesseRotation = 10F;
    void Start()
    {

    }   

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(0,_vitesseRotation * Time.deltaTime, 0) ;
    }
}
