using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip : MonoBehaviour
{
    Transform _tfCube;
    Renderer _rdrCube;
    // Start is called before the first frame update
    void Start()
    {
        _tfCube = GetComponent<Transform>();
        _rdrCube = GetComponent<Renderer>();


        switch(_tfCube.tag)
        {
            case "Bleu":
                _rdrCube.material.SetColor("_Color", Color.blue);
                break;
            case "Noir":
                _rdrCube.material.SetColor("_Color", Color.black);
                break;
            case "Blanc":
                _rdrCube.material.SetColor("_Color", Color.white);
                break;
            case "Marron":
                _rdrCube.material.SetColor("_Color", Color.gray);
                break;
        }

    }
    void movementbleu()
    {
        //code mouvement bleu
    }
    // Update is called once per frame
    void Update()
    {
        switch (_tfCube.tag)
        {
            case "Bleu":
                movementbleu();
                break;
            case "Noir":
                _rdrCube.material.SetColor("_Color", Color.black);
                break;
            case "Blanc":
                _rdrCube.material.SetColor("_Color", Color.white);
                break;
            case "Marron":
                _rdrCube.material.SetColor("_Color", Color.gray);
                break;
        }
    }
}
