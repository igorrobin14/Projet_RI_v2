using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arme : MonoBehaviour
{
    private RaycastHit hit;
    private Vector3 raycastDirection;
    public float maxRaycastDistance;
    public float timer;
    private float _tempsMin;
    public float _timerRecolte;
    private int _lvl;
    private float _tempsRecolte;
    public Minage Minage;
    // Start is called before the first frame update
    void Start()
    {
        //_score = 0;
        _lvl = 1;
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
                            Minage._score += 1 * _lvl;
                        }
                    }
                }
            }
        }
    }
}
