using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{
    public Rigidbody _rigidBodyPlayer;

    public float _jumpAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBodyPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidBodyPlayer.AddForce(Vector3.up * _jumpAmount, ForceMode.Impulse);
        }
    }
}

/*
public Rigidbody2D rb;
public float jumpAmount = 10;
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
    }
}
*/