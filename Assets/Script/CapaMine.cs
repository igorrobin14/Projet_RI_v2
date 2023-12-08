using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CapaMine : MonoBehaviour
{
    public Minage Minage;
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = Minage._score + "/150";
        
    }
}
