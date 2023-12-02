using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportation : MonoBehaviour
{


    public GameObject _leftTeleportation;
    public GameObject _rightTeleportation;

    public InputActionProperty _leftActivate;
    public InputActionProperty _rightActivate;

    public InputActionProperty _leftCancel;
    public InputActionProperty _rightCancel;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _leftTeleportation.SetActive(_leftCancel.action.ReadValue<float>() ==0 && _leftActivate.action.ReadValue<float>() > 0.1f);
        _rightTeleportation.SetActive(_rightCancel.action.ReadValue<float>() == 0 && _rightActivate.action.ReadValue<float>() > 0.1f);

    }
}
