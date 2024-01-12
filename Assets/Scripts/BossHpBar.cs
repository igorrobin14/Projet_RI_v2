using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class bossHpBar : MonoBehaviour
{
    static public float _bossHealth;
    Scrollbar _bossHpBar;
    public float _bossMaxHp=20;
    //public int _bossHealth;
    // Start is called before the first frame update
    void Start()
    {
        _bossHealth = _bossMaxHp;
        _bossHpBar = GetComponent<Scrollbar>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_bossHealth);
        _bossHpBar.size = _bossHealth / _bossMaxHp;
    }
    private void _healthUpdate(int _damage)
    {
        _bossHealth -= _damage;
    }
}
