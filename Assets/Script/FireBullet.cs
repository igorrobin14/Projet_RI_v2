using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{

    public GameObject _bullet;
    public Transform _spawnPoint;
    public float _fireSpeed=20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBulet);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FireBulet(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(_bullet);
        spawnedBullet.transform.position=_spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = _spawnPoint.forward*_fireSpeed;
        Destroy(spawnedBullet, 5);

    }
}
