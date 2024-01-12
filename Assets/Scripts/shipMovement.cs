using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class followLevier : MonoBehaviour
{
    private GameObject RotLevier;
    private Transform _tfRotLevier;

    private GameObject TranslationLevier;
    private Transform _tfTranslationLevier;

    private Transform _tfShip;
    private Rigidbody _rbShip;
    private float _grab;

    private float rotationSpeed = 0.02f;
    private float movementSpeed = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        
        RotLevier = GameObject.FindWithTag("RotationLever");
        _tfRotLevier = RotLevier.GetComponent<Transform>();
        TranslationLevier = GameObject.FindWithTag("TranslationLever");
        _tfTranslationLevier = RotLevier.GetComponent<Transform>(); ;
        _tfShip = GetComponent<Transform>();
        _rbShip = GetComponent<Rigidbody>();

        _grab = GameObject.FindWithTag("main").GetComponent<handInputsListener>()._gripValue;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Rotation : " + _tfRotLevier.eulerAngles.x +" ; "+  0 +" ; "+ _tfRotLevier.eulerAngles.z);
        _tfShip.Rotate((_tfRotLevier.eulerAngles.x) *rotationSpeed* Time.deltaTime,  0, (_tfRotLevier.eulerAngles.z) * rotationSpeed * Time.deltaTime);
        // -_tfShip.eulerAngles.z

        //_tfShip.position = _tfShip.position + new Vector3(Mathf.Cos(_tfRotLevier.eulerAngles.x * Mathf.PI / 180) * movementSpeed * Time.deltaTime, 0, Mathf.Cos(_tfRotLevier.eulerAngles.z * Mathf.PI / 180) * movementSpeed * Time.deltaTime);
        //Debug.Log("Translation : " + Mathf.Cos(_tfRotLevier.eulerAngles.x* Mathf.PI/180) * movementSpeed+ " ; "+ 0 + " ; " + Mathf.Cos(_tfRotLevier.eulerAngles.z * Mathf.PI / 180) *movementSpeed);

    }
}
