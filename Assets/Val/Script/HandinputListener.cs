using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class HandinputListener : MonoBehaviour
{
    public InputActionProperty gripaction;
    public Animator handanimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gripValue = gripaction.action.ReadValue<float>();
        handanimator.SetFloat("Grip", gripValue);
        
    }
}
