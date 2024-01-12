using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handInputsListener : MonoBehaviour
{

    public InputActionProperty _grip;
    public float _gripValue;
    public Animator _handAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _gripValue = _grip.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip", _gripValue);
    }
}
