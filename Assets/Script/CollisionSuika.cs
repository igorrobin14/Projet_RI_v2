using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CollisionSuika : MonoBehaviour
{
    public GameObject BalleRouge;
    public GameObject BalleVert;
    private Transform spawnBalle;
    private GameObject newPrefabInstance;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y>1.5f)
        {
            Destroy(gameObject);
            Debug.Log("TropHaut");
        }
        changementName();

    }


    public void changementName()
    {
        if (GameObject.Find("SuikaBall Rouge(2)(Clone)"))
        {
            GameObject changeRouge = GameObject.Find("SuikaBall Rouge(2)(Clone)");
            changeRouge.name = "Rouge";
        }
        if (GameObject.Find("SuikaBall Vert(3)(Clone)"))
        {
            GameObject changeVert = GameObject.Find("SuikaBall Vert(3)(Clone)");
            changeVert.name = "Vert";

        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BalleBleu"))  
        {
            spawnBalle = collision.gameObject.GetComponent<Transform>();
            if (!GameObject.Find("SuikaBall Rouge(2)(Clone)")) //SuikaBall Rouge n'existe pas)
            {
                newPrefabInstance = Instantiate(BalleRouge, spawnBalle.position, spawnBalle.rotation);
              
            }
            
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.CompareTag("BalleRouge"))
        {
            spawnBalle = collision.gameObject.GetComponent<Transform>();
            if (!GameObject.Find("SuikaBall Vert(3)(Clone)")) //SuikaBall Vert n'existe pas
            {
                newPrefabInstance = Instantiate(BalleVert, spawnBalle.position, spawnBalle.rotation);
            }
            Destroy(collision.gameObject);
        }

    }
}

