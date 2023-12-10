using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCanon : MonoBehaviour
{
    public Transform _canonDroit;
    public Transform _canonGauche;
    private Transform _gouvernail;

    // Start is called before the first frame update
    void Start()
    {
        _gouvernail=GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        _canonDroit.SetLocalPositionAndRotation(_canonDroit.position, transform.rotation);
        _canonGauche.SetLocalPositionAndRotation(_canonGauche.position, transform.rotation);



    }
}
