using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
{

    [SerializeField] private GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        playerObject.GetComponent<PlayerCollisionDetector>().OnPlayerEvent += StopPlayer_OnPlayerEvent;
    }

    private void StopPlayer_OnPlayerEvent()
    {
        Debug.Log("Landed!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
