using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtatCanon : MonoBehaviour
{
    public bool _minage;
    public bool _arme;
    public Renderer _canonDroit;
    public Renderer _canonGauche;
    // Start is called before the first frame update
    void Start()
    {
        _minage=true;
        _arme=false;

        
    }

    // Update is called once per frame
    void Update()
    {
        Etat();
        
    }
    void Etat()
    {
        if (_arme== true)
        {
            if (_canonDroit.material.color != Color.red)
            {
                _canonDroit.material.color = Color.red;
            }
            if (_canonGauche.material.color != Color.red)
            {
                _canonGauche.material.color = Color.red;
            }
        }
    
    
    
        if(_minage==true)
        {
            if (_canonDroit.material.color != Color.white)
            {
                _canonDroit.material.color = Color.white;
            }
             if (_canonGauche.material.color != Color.white)
            {
                _canonGauche.material.color = Color.white;
            }
        }


    }
    
}
