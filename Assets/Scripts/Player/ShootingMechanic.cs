using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMechanic : MonoBehaviour
{
    //EVENT SYSTEM : INFORMS THAT BULLET WAS SHOT
    public delegate void OnShootEventHandler();
    public OnShootEventHandler OnShootEvent;


    private GameObject playerObject;
    [SerializeField] GameObject bulletObject;

    private GameObject bulletInstance;


    private float bulletSpeed = 1000f;

    private float fireRate = .5f;
    private float nextShot = 0f;
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
        if (Input.GetMouseButtonDown(0) && Time.time > nextShot)
        {
            nextShot = Time.time + fireRate;

            bulletInstance = Instantiate(bulletObject, transform.position, transform.rotation);   
        }
    }

    void SetBulletDirection()
    {
        //Method will calculate direction of the bullet based on Enumerator placed in Movement script, it will return single value which will be used in bullet controller to push bullet according to player direction
    }
}
