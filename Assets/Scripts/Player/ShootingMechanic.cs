using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMechanic : MonoBehaviour
{

    [SerializeField] GameObject playerObject;
    [SerializeField] GameObject bulletObject;

    private float bulletSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletObject, transform.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * bulletSpeed);
        }
    }

}
