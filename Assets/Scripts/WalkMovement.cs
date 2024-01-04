using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkMovement : MonoBehaviour
{
    float _rotationX = 0.0f;
    float _rotationY = 0.0f;

    public float sensivity = 3f;

    public GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _rotationX += Input.GetAxis("Mouse X") * sensivity;
        _rotationY += Input.GetAxis("Mouse Y") * sensivity;
        _rotationY = Mathf.Clamp(_rotationY, -90, 90);
        _player.GetComponent<Transform>().localRotation = Quaternion.Euler(0, _rotationX, 0);
        GetComponent<Transform>().localRotation = Quaternion.Euler(-_rotationY, 0, 0);
    }
}
