using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;

    private float movementSpeed = 1f;
    private float jumpStrength = 100f;

    private const float STATIC_SPEED = 10f;

    // Start is called before the first frame update

    public enum PlayerLandState
    {
        Grounded,
        MidAir
    }

    [SerializeField]private PlayerLandState playerLandState;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerLandState = PlayerLandState.MidAir;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //rigidbody.AddForce();
            transform.Translate(new Vector2(-STATIC_SPEED * movementSpeed * Time.deltaTime, 0f));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //rigidbody.AddForce();
            transform.Translate(new Vector2(STATIC_SPEED * movementSpeed * Time.deltaTime, 0f));
        }
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && playerLandState == PlayerLandState.Grounded)
        {
            //By adding ForceMode we immidietaly uses force on object instead of gradually adding force to it, thus fixin the problem of low jumps
            rigidbody.AddForce(new Vector2(0f, STATIC_SPEED * jumpStrength * Time.deltaTime), ForceMode2D.Impulse);
            
            playerLandState = PlayerLandState.MidAir;
        }
    }

    public void ChangePlayerState(PlayerLandState pls)
    {
        playerLandState = pls;
    }
    public PlayerLandState GetPlayerState()
    {
        return this.playerLandState;
    }


    //PS: REMEMBER THAT YOU HAVE 2D ENVIROMENT NOW ASSHOLE SO NORMAL ON COLLISION ENTER WONT WORK
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag.Equals("Ground"))
        {    
            playerLandState = PlayerLandState.Grounded;
        }
    }
}




