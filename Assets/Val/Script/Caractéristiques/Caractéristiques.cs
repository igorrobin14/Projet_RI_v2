using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Caractéristiques : MonoBehaviour
{
    public int _monnaie;
    public TextMeshProUGUI _monnaieText;

    public int prixUnit;
    public TextMeshProUGUI _prixUnitText;

    public int _argentGagnée;
    public TextMeshProUGUI _argentGagnéeText;


    public int _niveauCommerce = 1;
    public Vente vente;
    // Start is called before the first frame update
    void Start()
    {
        prixUnit = prixUnit * _niveauCommerce;
        
    }

    // Update is called once per frame
    void Update()
    {
        _monnaieText.text = "Solde : "+ _monnaie + " $";
        _prixUnitText.text = "Prix : " + prixUnit + "/u $";
        _argentGagnée = prixUnit * vente.sellQuantity;
        _argentGagnéeText.text = "+" + _argentGagnée;

        
    }
}
