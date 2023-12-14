using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class SellButton : MonoBehaviour
{
    public Vente sellQuantityController; 
    public CapaMine scoreText; // Référence au texte affichant le score
    public Minage minage; // Variable de score
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SellButtonClicked);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SellButtonClicked()
    {

        // Soustrayez la quantité vendue du score
        minage._score -= sellQuantityController.sellQuantity;

        // Mettez à jour le texte du score
        scoreText.Text.text = minage._score + "/150";
    }
}
