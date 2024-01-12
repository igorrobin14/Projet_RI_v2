using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RayCastShooter : MonoBehaviour
{
    LineRenderer _aim;
    Material _matRock;
    public InputActionProperty _grip;
    public InputActionProperty _primButton;
    bool _rayOn = true;
    Vector3 _directionRay;
    Vector3 _positionDepart;
    Transform _tfHand;
    float _shootCooldown = 1.5f;
    float _shootTimer = 0;
    int _weaponType = 0;
    int _weaponTypeNumber = 2;
    float _weaponChangeTimer = 0;
    float _weaponChangeCooldown = 1f;
    int _nbWeaponType = 2;
    // Start is called before the first frame update
    void Start()
    {
        _tfHand = GetComponent<Transform>();
        _matRock = Resources.Load<Material>("Assets/Assets/Rock/texture/Materials/Stone_specular.mat");
        _aim = GetComponent<LineRenderer>();
        _aim.startWidth = 0.005f;
        _aim.endWidth = 0.005f;

    }




    //gestion du tir 
    void _shootAttempt()
    {
        _shootTimer += Time.deltaTime;
        float _gripState = _grip.action.ReadValue<float>();

        RaycastHit hit;
        _positionDepart = _tfHand.position;
        _directionRay = _tfHand.forward;
        //Debug.DrawRay(_positionDepart, _directionRay, Color.green);

        if (_gripState > 0.5)
        {

            if (Physics.Raycast(_positionDepart, _directionRay, out hit, 100) && _rayOn && _shootTimer >= _shootCooldown)
            {
                Transform _tfHit = hit.collider.GetComponent<Transform>();

                if (_tfHit.tag == "WeakToPlasma" && _weaponType == 0)
                {
                    Destroy(hit.collider.gameObject);
                }
                else
                {
                    if (_tfHit.tag == "WeakToIon" && _weaponType == 1)
                    {
                        Destroy(hit.collider.gameObject);
                    }

                }
                _shootTimer = 0;

            }

        }
    }
    void _weaponTypeChange()
    {
        float _primbuttonvalue = _primButton.action.ReadValue<float>();
        //Debug.Log(" sdbsqdqs   " +_primbuttonvalue);
        _weaponChangeTimer += Time.deltaTime;
        if (_primbuttonvalue > 0.5f && _weaponChangeTimer > _weaponChangeCooldown)
        {
            _weaponType = (_weaponType+1)%_nbWeaponType;
            //Debug.Log(_weaponType);
            _weaponChangeTimer=0;
        }
    }

    void _weaponAimDraw()
    {
        
        _aim.SetPosition(0, _positionDepart);
        _aim.SetPosition(1, _positionDepart + 1000 * _directionRay);
        switch (_weaponType)
        {
            case 0:
                _aim.startColor = Color.red;
                _aim.endColor = Color.red;
                break;
            case 1:
                _aim.startColor = Color.green;
                _aim.endColor = Color.green;
                break;
            default:
                break;
        }

    }
    // Update is called once per frame
    void Update()
    {
        _weaponType %=_weaponTypeNumber; // always have a weapon type active
        _shootAttempt();
        _weaponTypeChange();
        _weaponAimDraw();
    }
}
