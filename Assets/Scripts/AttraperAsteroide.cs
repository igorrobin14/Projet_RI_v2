using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttraperAsteroide : MonoBehaviour
{
    public InputActionProperty Action;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float A_value = Action.action.ReadValue<float>();
        Debug.Log(A_value);
        
    }
}
