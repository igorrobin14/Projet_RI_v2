using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{

    public GameObject _bullet;
    public Transform _spawnPoint;
    private Transform _Arme;
    private Quaternion _rotationBullet;
    public float _fireSpeed=20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBulet);
        _Arme = GetComponent<Transform>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotationBullet = _Arme.rotation;
        
        
        
    }
    public void FireBulet(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(_bullet,_spawnPoint.position,_rotationBullet);
        spawnedBullet.transform.position=_spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = -_spawnPoint.up*_fireSpeed;
        Destroy(spawnedBullet, 5);

    }
}
