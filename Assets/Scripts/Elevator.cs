using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Collider _myCollider;

    private Collider _colliderPorteHaute, _colliderPorteBasse;

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
        _elevatorDown = false;
        _timer = 0f;
        _delay = 4f;
        _player = GameObject.Find("XR Origin (XR Rig)");
        _colliderPorteHaute = GameObject.Find("Porte Haute").GetComponent<BoxCollider>();
        _colliderPorteBasse = GameObject.Find("Porte Basse").GetComponent<BoxCollider>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other != null)
        {
            if (other.CompareTag("Player"))
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
            if (other.CompareTag("Player"))
            {
                Debug.Log("Player not on elevator");
                _playerOnElevator = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //OnTriggerStay(_myCollider);

        if (_playerOnElevator == true)
        {
            _player.GetComponent<Transform>().SetParent(GetComponent<Transform>(), true);
            // _player.GetComponent<Transform>().localScale = new Vector3(1 / GetComponent<Transform>().localScale.x, 1 / GetComponent<Transform>().localScale.y, 1 / GetComponent<Transform>().localScale.z);
            if (_elevatorDown == true)
            {
                _timer += Time.deltaTime;
                if (_timer > _delay)
                {
                    if (GetComponent<Transform>().position.y < 2.225f)
                    {
                        GetComponent<Transform>().Translate(Vector3.up * Time.deltaTime * _speed);
                        _colliderPorteHaute.enabled = false;
                    }
                    else
                    {
                        _player.GetComponent<Transform>().SetParent(null);
                        _elevatorDown = false;
                        _timer = 0;
                        _colliderPorteHaute.enabled = true;
                    }
                }
            }
            else
            {
                _timer += Time.deltaTime;
                if (_timer > _delay)
                {
                    _player.GetComponent<Transform>().SetParent(GetComponent<Transform>(), true);
                    if (GetComponent<Transform>().position.y > -1.7f)
                    {
                        GetComponent<Transform>().Translate(Vector3.down * Time.deltaTime * _speed);
                        _colliderPorteBasse.enabled = false;
                    }
                    else
                    {
                        _player.GetComponent<Transform>().SetParent(null);
                        _elevatorDown = true;
                        _timer = 0;
                        _colliderPorteBasse.enabled = true;
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
