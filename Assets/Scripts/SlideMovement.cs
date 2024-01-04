using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMovement : MonoBehaviour
{
    public Transform player;

    public float _inputX;
    public float _inputZ;

    public float _speed = 4.0f;

    public GameObject _camera;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
        _camera = GameObject.Find("Main Camera");
    }

    public void moveX()
    {
        player.Translate(Vector3.right * (_inputX * _speed * Time.deltaTime), Space.Self);
    }

    public void moveZ()
    {
        player.Translate(Vector3.forward * (_inputZ * _speed * Time.deltaTime), Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        _inputX = Input.GetAxis("Horizontal");
        _inputZ = Input.GetAxis("Vertical");
            
        moveX();
        moveZ();

        if (GetComponent<Transform>().position.y < -2)
        {
            GetComponent<Transform>().position = new Vector3(-0.29f, 1.8f, 0.85f);
        }
    }
}
