using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{

    [SerializeField] GameObject playerObject;


    private Transform playerTransform;
    private ShootingMechanic playerShootingMechanic;

    private Vector2 dir;

    private void Start()
    {
        playerTransform = playerObject.transform;
        playerShootingMechanic = playerObject.GetComponent<ShootingMechanic>();
    }

    void Update()
    {

        Destroy(gameObject, 3f);
    }


}
