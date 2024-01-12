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
    

    // Start is called before the first frame update
    void Start()
    {
        
        
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
      
    
         
    }

    void Ray()
    {
        // D�finir la direction du raycast vers l'avant (en utilisant la direction du transform.forward)
        Vector3 raycastDirection = -transform.up;



        // Effectuer le raycast
        if (Physics.Raycast(transform.position, raycastDirection, out hit, maxRaycastDistance))
        {
            // Si le raycast frappe quelque chose, imprimer le tag de l'objet touch� dans la console
            Debug.Log("Objet touch� : " + hit.transform.tag);
        }

        // Dessiner une ligne rouge repr�sentant le raycast dans l'�diteur Unity
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
    
}
