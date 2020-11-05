using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    public delegate void OnPlayerEventHandler();
    public event OnPlayerEventHandler OnPlayerEvent;

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Ground"))
        {
            gameObject.GetComponent<Movement>().ChangePlayerState(Movement.PlayerLandState.Grounded);
        }
    */
}
