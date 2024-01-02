using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private GameObject _gateLeftA, _gateLeftB, _gateRightA, _gateRightB;
   
    // Start is called before the first frame update
    void Start()
    {
        _gateLeftA = GameObject.Find("Gate Left A");
        _gateLeftB = GameObject.Find("Gate Left B");
        _gateRightA = GameObject.Find("Gate Right A");
        _gateRightB = GameObject.Find("Gate Right B");
       
    }

    // Update is called once per frame
    void Update()
    {
            _gateLeftA.transform.Translate((Vector3.left * GetComponent<Transform>().rotation.x)/50);
           // _gateLeftA.transform.localPosition = new Vector3(Mathf.Clamp(_gateLeftA.transform.localPosition.x, -4f, -0.47f), 0, 0);
        //_gateLeftB.GetComponent<Transform>().localPosition = new Vector3(-1.15f + GetComponent<Transform>().rotation.x, -1.86f, 38.73f);
        

    }
}
