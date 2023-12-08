using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Collider _myCollider;
    public GameObject _player;

    public bool _playerOnElevator;
    public bool _elevatorDown;

    public float _timer;
    public float _delay;
    public float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        _myCollider = GetComponent<Collider>();
        _playerOnElevator = false;
        _elevatorDown = true;
        _timer = 0f;
        _delay = 2f;
        _player = GameObject.Find("XR Origin (XR Rig)");
    }

    void OnTriggerStay(Collider other)
    {
        if (other != null)
        {
            if (other.CompareTag("Character"))
            {
                Debug.Log("Player on elevator");
                _playerOnElevator = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            if (other.CompareTag("Character"))
            {
                Debug.Log("Player not on elevator");
                _playerOnElevator = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerStay(_myCollider);

        if (_playerOnElevator == true)
        {
            if (_elevatorDown == true)
            {
                _timer += Time.deltaTime;
                if (_timer > _delay)
                {
                    _player.GetComponent<Transform>().SetParent(GetComponent<Transform>());
                    if (GetComponent<Transform>().position.y < 2.65f)
                    {
                        GetComponent<Transform>().Translate(Vector3.up * Time.deltaTime * _speed);
                    }
                    else
                    {
                        _player.GetComponent<Transform>().SetParent(null);
                        _elevatorDown = false;
                        _timer = 0;
                    }
                }
            }
            else
            {
                _timer += Time.deltaTime;
                if (_timer > _delay)
                {
                    _player.GetComponent<Transform>().SetParent(GetComponent<Transform>());
                    if (GetComponent<Transform>().position.y > -1.3f)
                    {
                        GetComponent<Transform>().Translate(Vector3.down * Time.deltaTime * _speed);
                    }
                    else
                    {
                        _player.GetComponent<Transform>().SetParent(null);
                        _elevatorDown = true;
                        _timer = 0;
                    }
                }
            }
        }
        else
        {
            _player.GetComponent<Transform>().SetParent(null);
        }
    }
}
