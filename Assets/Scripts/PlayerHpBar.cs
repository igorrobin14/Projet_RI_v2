using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PlayerHpBar : MonoBehaviour
{
    static public float _playerHealth;
    Scrollbar _playerHpBar;
    public float _playerMaxHp=20;
    //public int _playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = _playerMaxHp;
        _playerHpBar = GetComponent<Scrollbar>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_playerHealth);
        _playerHpBar.size = _playerHealth / _playerMaxHp;
    }
    private void _healthUpdate(int _damage)
    {
        _playerHealth -= _damage;
    }
}
