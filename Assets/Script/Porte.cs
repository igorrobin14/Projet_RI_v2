using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public Transform droite;
    public Transform gauche;
    public Vector3 _xDroite;
    public Vector3 _xGauche;
    





    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        droite.Translate(_xDroite);
        gauche.Translate(_xGauche);




    }

    private void OnTriggerExit(Collider other)
    {
        droite.Translate(-_xDroite);
        gauche.Translate(-_xGauche);
        Debug.Log("vff");



    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
