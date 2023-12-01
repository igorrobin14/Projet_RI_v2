using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandinputListener : MonoBehaviour
{
    public InputActionProperty gripAction;
    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float gripValue = gripAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
