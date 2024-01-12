using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciationAsteroide : MonoBehaviour
{
    // Start is called before the first frame update
    private int _nombreAsteroides = 40;
    private Transform _transformSaturne;
    public GameObject Asteroide1, Asteroide2, Asteroide3;
    private Vector3 Pos;
    private int aleatoireX, aleatoireY, aleatoireZ;
    public Material gold, iron, charcoal;
   
    void Start()
    {
        _transformSaturne = GetComponent<Transform>();
        

        Anneau();
    }

    void genereAlea()
    {
        aleatoireX = Random.Range((int)Pos[0] - 3, (int)Pos[0] + 3);
        aleatoireY = Random.Range((int)Pos[1] - 3, (int)Pos[1] + 3);
        aleatoireZ = Random.Range((int)Pos[2] - 3, (int)Pos[2] + 3);

        Pos[0] = aleatoireX;
        Pos[1] = aleatoireY;
        Pos[2] = aleatoireZ;
    }

    void Instanciation(GameObject Ast)
    {
        genereAlea();
        GameObject asteroid = Instantiate(Ast, Pos, Quaternion.identity) ;
        GameObject Child = asteroid.transform.GetChild(0).gameObject;

        float randomFloat = Random.value;
        if (randomFloat < 0.05)
        {
            Child.transform.GetChild(0).GetComponent<MeshRenderer>().material = gold;
            Child.transform.GetChild(1).GetComponent<MeshRenderer>().material = gold;
            Child.transform.GetChild(2).GetComponent<MeshRenderer>().material = gold;
            asteroid.tag = "gold";
        }
        else
        {
            if (randomFloat>=0.05 && randomFloat<0.2)
            {
                Child.transform.GetChild(0).GetComponent<MeshRenderer>().material = iron;
                Child.transform.GetChild(1).GetComponent<MeshRenderer>().material = iron;
                Child.transform.GetChild(2).GetComponent<MeshRenderer>().material = iron; ;
                asteroid.tag = "iron";
            }
            else if(randomFloat >= 0.2 && randomFloat < 0.4)
            {
                Child.transform.GetChild(0).GetComponent<MeshRenderer>().material = charcoal;
                Child.transform.GetChild(1).GetComponent<MeshRenderer>().material = charcoal;
                Child.transform.GetChild(2).GetComponent<MeshRenderer>().material = charcoal;
                asteroid.tag = "charcoal";
            }
        }
    }


    void Anneau()
    {
       
        float rayon = 60;
        float angle = 0;
        for (int j = 0; j < 2; j++)
        {
            for (int i = 0; i < _nombreAsteroides; i++)
            {
                Pos = _transformSaturne.position;
                Pos[0] = Pos[0] + rayon * Mathf.Cos(angle);
                Pos[2] = Pos[2] + rayon * Mathf.Sin(angle);

                for (int k = 0; k < 5; k++)
                {
                    Instanciation(Asteroide1);
                    Instanciation(Asteroide2);
                    Instanciation(Asteroide3);
                }
                angle = angle + (2 * Mathf.PI) / _nombreAsteroides;
            }
            rayon = rayon + 5;
        }
    }
}


