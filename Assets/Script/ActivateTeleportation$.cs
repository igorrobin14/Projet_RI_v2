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

    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);

        _leftTeleportation.SetActive(!isLeftRayHovering &&  _leftCancel.action.ReadValue<float>() ==0 && _leftActivate.action.ReadValue<float>() > 0.1f);

        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);

        _rightTeleportation.SetActive(!isRightRayHovering  && _rightCancel.action.ReadValue<float>() == 0 && _rightActivate.action.ReadValue<float>() > 0.1f);

    }
}
