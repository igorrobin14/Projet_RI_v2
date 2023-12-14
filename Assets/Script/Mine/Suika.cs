using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suika : MonoBehaviour
{

    public GameObject prefabToSpawn; // Le prefab que vous souhaitez instancier
    public Transform  pointOfSpawn;   // Le point de spawn où vous souhaitez instancier le prefab
    public Transform  parentObject;   // L'objet existant auquel vous souhaitez attacher le nouveau prefab
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPrefabAtPoint();
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPrefabAtPoint()
    {
        // Vérifiez si le prefab et le point de spawn sont définis
        if (prefabToSpawn != null && pointOfSpawn != null)
        {
            // Instancier le prefab au point de spawn
            GameObject newPrefabInstance = Instantiate(prefabToSpawn, pointOfSpawn.position, pointOfSpawn.rotation);

            // Vérifiez si l'objet parent est défini
            if (parentObject != null)
            {
                // Rendre le nouvel objet instancié enfant de l'objet parent
                newPrefabInstance.transform.parent = parentObject;
            }
            //newPrefabInstance.tag = "BalleBleu";
        }
        else
        {
            Debug.LogError("Prefab ou point de spawn non défini !");
        }
    }
}
