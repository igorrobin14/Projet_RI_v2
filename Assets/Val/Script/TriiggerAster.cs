using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriiggerAster : MonoBehaviour
{
    public Minage Minage;
    private int _lvl;
    // Start is called before the first frame update
    void Start()
    {
        _lvl = 1;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other != null)
            {
                if (other.CompareTag("AsterOR"))
                {
                    Minage._score += 1 * _lvl;
                    Destroy(other.gameObject);
                }
            }
        }
    }


}
