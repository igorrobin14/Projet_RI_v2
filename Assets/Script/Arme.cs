using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arme : MonoBehaviour
{
    public float maxRaycastDistance;
    public float timer;
    public float _timerRecolte;

    private RaycastHit hit;
    private Vector3 raycastDirection;
    private float _tempsMin;
   
    private float _tempsRecolte;
   
    public Transform _parentAsterOr;
    public GameObject _prefabAsterOr;
    public GameObject _cible;

    private GameObject test;

    public Minage Minage;
    public bool _minage;
    public bool _arme;

    // Start is called before the first frame update
    void Start()
    {
        _minage = true;
        _arme = false;
        
        raycastDirection = -transform.up;
        maxRaycastDistance = 10f;
        _tempsRecolte = 2f;
       
        //Minage._score = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Ray();
        updateScore();
        EtatMinage();
        EtatArme();
        //toggle();
         
    }

    void Ray()
    {
        // Définir la direction du raycast vers l'avant (en utilisant la direction du transform.forward)
        Vector3 raycastDirection = -transform.up;



        // Effectuer le raycast
        if (Physics.Raycast(transform.position, raycastDirection, out hit, maxRaycastDistance))
        {
            // Si le raycast frappe quelque chose, imprimer le tag de l'objet touché dans la console
            Debug.Log("Objet touché : " + hit.transform.tag);
        }

        // Dessiner une ligne rouge représentant le raycast dans l'éditeur Unity
        Debug.DrawRay(transform.position, raycastDirection * maxRaycastDistance, Color.red);
    }
    void updateScore()
    {

        if (Physics.Raycast(transform.position, raycastDirection, out hit, maxRaycastDistance))
        {
            if (hit.collider.CompareTag("Or"))
            {
                Debug.Log("Or");
                if (hit.distance < maxRaycastDistance)
                {
                    timer += Time.deltaTime;
                    if (timer > _tempsMin)
                    {
                        _timerRecolte += Time.deltaTime;
                        if (_timerRecolte > _tempsRecolte)
                        {
                            _timerRecolte = 0;
                            Instantiate(_prefabAsterOr, hit.transform.position, Quaternion.identity,_parentAsterOr);
                        }
                    }
                }
            }
        }
    }

    void EtatMinage()
    {
        if(_minage==true)
        {
            if (GetComponent<Renderer>().material.color != Color.black)
            {
                GetComponent<Renderer>().material.color = Color.black;
            }
        }


    }

    void EtatArme()
    {
        if (_arme == true)
        {
            if (GetComponent<Renderer>().material.color != Color.red)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
    
    void toggle()
    {
        if(_arme==true)
        {
            _minage = false;
        }
        if(_minage==true)
        {
            _arme = false;
        }
    }
}
