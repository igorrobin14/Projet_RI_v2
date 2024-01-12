using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciateur : MonoBehaviour
{
    public GameObject  _prefabPlasmaWeakRock;
    public GameObject _prefabIonWeakRock;
    GameObject[] _rockList;
    int _nbRock;
    Quaternion _rotationVide;
    Vector3 _spawnPosition;
    float _spawnCooldown = 0.5f;
    float _spawnTimer = 0;
    int _choixRock;
    // Start is called before the first frame update
    void Start()
    {
        //_prefabRock = Resources.Load<GameObject>("Assets/Prefab/Rock.prefab");
        //Debug.Log(_prefabPlasmaWeakRock);
        _rockList = new GameObject[25];
        _nbRock = 0;
        _rotationVide = new Quaternion(0, 0, 0, 0);
        _spawnPosition = new Vector3(1, 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTimer += Time.deltaTime;
        if(_nbRock<25 && _spawnTimer >= _spawnCooldown)
        {
             _choixRock = Random.Range(0, 2);
            switch(_choixRock)
            {
                case 0:
                    Instantiate(_prefabPlasmaWeakRock, _spawnPosition * Random.Range(50,100)/100, _rotationVide);
                    _spawnTimer = 0;
                    break;
                case 1:
                    Instantiate(_prefabIonWeakRock, _spawnPosition * Random.Range(50, 100) / 100, _rotationVide);
                    _spawnTimer = 0;
                    break;
            }
        }
    }
}
